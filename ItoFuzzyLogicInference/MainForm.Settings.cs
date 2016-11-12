using System;
using System.Linq;
using System.Windows.Forms;
using InferenceLibrary;

namespace ItoFuzzyLogicInference
{
    public partial class MainForm
    {
        private void xValueTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var textBox = (TextBox)sender;
            double parseResult;
            var parseSuccess = double.TryParse(textBox.Text, out parseResult);
            if (!parseSuccess)
            {
                MessageBox.Show(this, "Proszę wpisać liczbę rzeczywistą");
                e.Cancel = true;
                return;
            }
        }
        
        private void x1ValueTextBox_Validated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            var function = (MembershipFunction)textBox.Tag;
            function.X1 = double.Parse(textBox.Text);
            UpdateMembershipFunctionChart(function);
        }

        private void x2ValueTextBox_Validated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            var function = (MembershipFunction)textBox.Tag;
            function.X2 = double.Parse(textBox.Text);
            UpdateMembershipFunctionChart(function);
        }

        private void x3ValueTextBox_Validated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            var function = (MembershipFunction)textBox.Tag;
            function.X3 = double.Parse(textBox.Text);
            UpdateMembershipFunctionChart(function);
        }

        private void x4ValueTextBox_Validated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            var function = (MembershipFunction)textBox.Tag;
            function.X4 = double.Parse(textBox.Text);
            UpdateMembershipFunctionChart(function);
        }

        private void UpdateMembershipFunctionChart(MembershipFunction function)
        {
            membershipFunctionChart.Series.First().Points[0].XValue = function.X1;
            membershipFunctionChart.Series.First().Points[1].XValue = function.X2;
            membershipFunctionChart.Series.First().Points[2].XValue = function.X3;
            membershipFunctionChart.Series.First().Points[3].XValue = function.X4;
            membershipFunctionChart.Series.First().Name = function.LinguisticVariable.DisplayName + " - " + function.DisplayName;
            membershipFunctionChart.ChartAreas.First().AxisX.Minimum = function.X1;
            membershipFunctionChart.ChartAreas.First().AxisX.Maximum = function.X4;
        }
        private void VariableNodeClicked(TreeNode node)
        {
        }

        private void FunctionNodeClicked(TreeNode node)
        {
            var function = (MembershipFunction)node.Tag;
            var variable = function.LinguisticVariable;
            x1UnitLabel.Text = x2UnitLabel.Text = x3UnitLabel.Text = x4UnitLabel.Text = variable.DisplayUnit;

            x1ValueTextBox.Tag = x2ValueTextBox.Tag = x3ValueTextBox.Tag = x4ValueTextBox.Tag = function;
            x1ValueTextBox.Text = function.X1.ToString();
            x2ValueTextBox.Text = function.X2.ToString();
            x3ValueTextBox.Text = function.X3.ToString();
            x4ValueTextBox.Text = function.X4.ToString();
            UpdateMembershipFunctionChart(function);
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
