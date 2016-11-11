using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using InferenceLibrary;

namespace ItoFuzzyLogicInference
{
    public partial class MainForm : Form
    {
        private const string ConfigurationFilePath = "inference.xml";
        private const int VariableInputCellIndex = 1;

        public DataRepository DataRepository { get; set; }
        public FuzzyInference FuzzyInference { get; private set; }
        
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataRepository = new DataRepository();
            var factory = new InferenceFactory(ConfigurationFilePath);
            FuzzyInference = factory.BuildInference();
            DataRepository.FuzzyRules = factory.FuzzyRules;
            DataRepository.LinguisticVariables = factory.LinguisticVariables;

            PopulateDecisionTypeComboBox();
            PopulateVariableInputs((LinguisticVariable)decisionTypeComboBox.SelectedItem);
            PopulateVariableTree();
        }

        private void PopulateVariableTree()
        {
            variablesTreeView.Nodes.Clear();
            foreach (var linguisticVariable in DataRepository.LinguisticVariables)
            {
                variablesTreeView.Nodes.Add(BuildVariableTreeNode(linguisticVariable));
            }
            FunctionNodeClicked(variablesTreeView.Nodes[0].FirstNode);
        }

        private TreeNode BuildVariableTreeNode(LinguisticVariable variable)
        {
            var variableNode = new TreeNode(variable.DisplayName);
            foreach (var membershipFunction in variable.MembershipFunctions)
            {
                variableNode.Nodes.Add(BuildFunctionTreeNode(membershipFunction));
            }
            variableNode.Tag = variable;

            return variableNode;
        }

        private TreeNode BuildFunctionTreeNode(MembershipFunction membershipFunction)
        {
            var functionNode = new TreeNode(membershipFunction.DisplayName);
            functionNode.Tag = membershipFunction;
            return functionNode;
            
        }

        private void PopulateVariableInputs(LinguisticVariable outputVariable)
        {
            inputValuesGrid.Rows.Clear();
            foreach (var variable in DataRepository.InputVariables(outputVariable))
            {
                var row = new DataGridViewRow {Tag = variable};
                var nameCell = new DataGridViewTextBoxCell {Value = variable.DisplayName};

                var valueCell = new DataGridViewTextBoxCell
                {
                    ValueType = typeof(double),
                    Value = 1
                };
                var unitCell = new DataGridViewTextBoxCell
                {
                    Value = variable.DisplayUnit
                };
                row.Cells.Add(nameCell);
                row.Cells.Add(valueCell);
                row.Cells.Add(unitCell);
                inputValuesGrid.Rows.Add(row);
            }
        }

        private void PopulateDecisionTypeComboBox()
        {
            decisionTypeComboBox.DataSource = DataRepository.ConclusionVariables.ToList();
            decisionTypeComboBox.DisplayMember = "DisplayName";
            decisionTypeComboBox.ValueMember = "Id";
        }
        
        private void VariableNodeClicked(TreeNode node)
        {
        }

        private void FunctionNodeClicked(TreeNode node)
        {
            var function = (MembershipFunction) node.Tag;
            var variable = function.LinguisticVariable;
            x1UnitLabel.Text = x2UnitLabel.Text = x3UnitLabel.Text = x4UnitLabel.Text = variable.DisplayUnit;
            x1ValueTextBox.Text = function.X1.ToString();
            x2ValueTextBox.Text = function.X2.ToString();
            x3ValueTextBox.Text = function.X3.ToString();
            x4ValueTextBox.Text = function.X4.ToString();

            membershipFunctionChart.Series.First().Points[0].XValue = function.X1;
            membershipFunctionChart.Series.First().Points[1].XValue = function.X2;
            membershipFunctionChart.Series.First().Points[2].XValue = function.X3;
            membershipFunctionChart.Series.First().Points[3].XValue = function.X4;
            membershipFunctionChart.Series.First().Name = variable.DisplayName + " - " + function.DisplayName;
            membershipFunctionChart.ChartAreas.First().AxisX.Minimum = function.X1;
            membershipFunctionChart.ChartAreas.First().AxisX.Maximum = function.X4;
        }

        private void variablesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag.GetType() == typeof(LinguisticVariable))
            {
                VariableNodeClicked(e.Node);
            }
            else if (e.Node.Tag.GetType() == typeof(MembershipFunction))
            {
                FunctionNodeClicked(e.Node);
            }
        }

        private void inputValuesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != VariableInputCellIndex)
            {
                return;
            }

            var row = inputValuesGrid.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];
            var variable = (LinguisticVariable)row.Tag;
            var conditions = DataRepository.ConditionsForVariable(variable);
            foreach (var condition in conditions)
            {
                condition.InputValue = double.Parse(cell.Value.ToString());
            }
        }

        private void inputValuesGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != VariableInputCellIndex)
            {
                return;
            }
            var row = inputValuesGrid.Rows[e.RowIndex];
            var variable = (LinguisticVariable) row.Tag;
            double parseResult;
            var parseSuccess = double.TryParse(e.FormattedValue.ToString(), out parseResult);
            if (!parseSuccess || parseResult < variable.Min || parseResult > variable.Max)
            {
                row.ErrorText = $"Wpisz wartość z przedziału: [{variable.Min}, {variable.Max}]";
                e.Cancel = true;
            }
            else
            {
                row.ErrorText = "";
            }
        }

        private DataGridViewCell CellFromCoords(int rowIndex, int columnIndex)
        {
            var row = inputValuesGrid.Rows[rowIndex];
            return row.Cells[columnIndex];
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var result = FuzzyInference.Infere();
            resultLabel.Show();
            resultLabel.Text = result.ToString();
        }
    }
}
