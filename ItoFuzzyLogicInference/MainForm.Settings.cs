using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            UpdateXLabels(function.Inverted);
        }

        private void UpdateMembershipFunctionChart(MembershipFunction function)
        {
            var series = membershipFunctionChart.Series.First();
            series.Points[0] = new DataPoint(function.X1, function.Inverted ? 1 : 0);
            series.Points[1] = new DataPoint(function.X2, function.Inverted ? 0 : 1);
            series.Points[2] = new DataPoint(function.X3, function.Inverted ? 0 : 1);
            series.Points[3] = new DataPoint(function.X4, function.Inverted ? 1 : 0);
            
            series.Name = function.LinguisticVariable.DisplayName + " - " + function.DisplayName;
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
            
            invertTrapezoidCheckbox.Tag = x1ValueTextBox.Tag = x2ValueTextBox.Tag = x3ValueTextBox.Tag = x4ValueTextBox.Tag = function;

            invertTrapezoidCheckbox.Checked = function.Inverted;

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

        private void UpdateXLabels(bool inverseTrapezoid)
        {
            if (inverseTrapezoid)
            {
                x1Label.Text = "x1 (lewa 1):";
                x2Label.Text = "x2 (lewe 0):";
                x3Label.Text = "x3 (prawe 0):";
                x4Label.Text = "x4 (prawa 1):";
            }
            else
            {
                x1Label.Text = "x1 (lewe 0):";
                x2Label.Text = "x2 (lewa 1):";
                x3Label.Text = "x3 (prawa 1):";
                x4Label.Text = "x4 (prawe 0):";
            }
        }

        private void invertTrapezoidCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            var function = (MembershipFunction) invertTrapezoidCheckbox.Tag;
            function.Inverted = invertTrapezoidCheckbox.Checked;
            UpdateXLabels(function.Inverted);
            UpdateMembershipFunctionChart(function);
        }
    }
}
