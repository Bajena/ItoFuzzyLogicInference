﻿using System;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using InferenceLibrary;

namespace ItoFuzzyLogicInference
{
    public partial class MainForm
    {
        private void calculateButton_Click(object sender, EventArgs e)
        {
            FuzzyInference.Infere();
            DisplayFuzzificationResults();
        }

        private void DisplayFuzzificationResults()
        {
            var currentVariable = (LinguisticVariable) decisionTypeComboBox.SelectedItem;

            fuzzificationResultListBox.Items.Clear();
            ruleEvaluationResultListBox.Items.Clear();
            aggregatedFunctionChart.Series.Clear();

            foreach (var fuzzificationResult in InferenceDetails.Instance.FuzzificationResults)
            {
                fuzzificationResultListBox.Items.Add(
                    $"{fuzzificationResult.Key.FullDisplayName}: {fuzzificationResult.Value}");
            }

            foreach (var evaluationResult in InferenceDetails.Instance.RuleEvaluationResults)
            {
                ruleEvaluationResultListBox.Items.Add(
                    $"{evaluationResult.Key.Text}: {evaluationResult.Value}");
            }


            var functionSeries = new Series("Zagregowana f. przynależności") { ChartType = SeriesChartType.Line, BorderWidth = 2 };
            var resultSeries = new Series($"Wynik: {InferenceDetails.Instance.Result.X}") { ChartType = SeriesChartType.Point, MarkerBorderWidth = 10 };
            foreach (var point in InferenceDetails.Instance.AggregatedFunction)
            {
                functionSeries.Points.AddXY(point.X, point.Y);
            }

            resultSeries.Points.AddXY(InferenceDetails.Instance.Result.X, InferenceDetails.Instance.Result.Y);
            aggregatedFunctionChart.Series.Add(functionSeries);
            aggregatedFunctionChart.Series.Add(resultSeries);
            aggregatedFunctionChart.Titles.First().Text = $"{currentVariable.DisplayName} ({currentVariable.DisplayUnit})";

            if (!tabControl.TabPages.Contains(resultsTabPage))
            {
                tabControl.TabPages.Add(resultsTabPage);
            }
        }
    }
}
