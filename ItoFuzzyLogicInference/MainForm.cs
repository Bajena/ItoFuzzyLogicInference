using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InferenceLibrary;
using InferenceLibrary.Rules;

namespace ItoFuzzyLogicInference
{
    public partial class MainForm : Form
    {
        private const string ConfigurationFilePath = "inference.xml";

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
            PopulateVariableInputs();
            PopulateVariableTree();
        }

        private void PopulateVariableTree()
        {
            variablesTreeView.Nodes.Clear();
            foreach (var linguisticVariable in DataRepository.LinguisticVariables)
            {
                variablesTreeView.Nodes.Add(BuildVariableTreeNode(linguisticVariable));
            }
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

        private void PopulateVariableInputs()
        {
//            throw new NotImplementedException();
        }

        private void PopulateDecisionTypeComboBox()
        {
            decisionTypeComboBox.DataSource = DataRepository.ConclusionMembershipFunctions.ToList();
            decisionTypeComboBox.DisplayMember = "DisplayName";
            decisionTypeComboBox.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void variablesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
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
    }
}
