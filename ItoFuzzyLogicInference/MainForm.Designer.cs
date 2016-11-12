namespace ItoFuzzyLogicInference
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Młody");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Średni");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Stary");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Wiek", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Małe");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Średnie");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Wysokie");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Średnie miesięczne wpływy", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(30D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(40D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.inputValuesLabel = new System.Windows.Forms.Label();
            this.rulesListBox = new System.Windows.Forms.ListBox();
            this.inputValuesGrid = new System.Windows.Forms.DataGridView();
            this.linguisticVariableNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linguisticVariableValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linguisticVariableUnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateButton = new System.Windows.Forms.Button();
            this.decisionTypeLabel = new System.Windows.Forms.Label();
            this.decisionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.variablesTreeView = new System.Windows.Forms.TreeView();
            this.invertTrapezoidCheckbox = new System.Windows.Forms.CheckBox();
            this.membershipFunctionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.x4UnitLabel = new System.Windows.Forms.Label();
            this.x3UnitLabel = new System.Windows.Forms.Label();
            this.x2UnitLabel = new System.Windows.Forms.Label();
            this.x1UnitLabel = new System.Windows.Forms.Label();
            this.x4ValueTextBox = new System.Windows.Forms.TextBox();
            this.x4Label = new System.Windows.Forms.Label();
            this.x3ValueTextBox = new System.Windows.Forms.TextBox();
            this.x3Label = new System.Windows.Forms.Label();
            this.x2ValueTextBox = new System.Windows.Forms.TextBox();
            this.x2Label = new System.Windows.Forms.Label();
            this.x1ValueTextBox = new System.Windows.Forms.TextBox();
            this.x1Label = new System.Windows.Forms.Label();
            this.resultsTabPage = new System.Windows.Forms.TabPage();
            this.evaluationResultLabel = new System.Windows.Forms.Label();
            this.fuzzificationResultsLabel = new System.Windows.Forms.Label();
            this.aggregatedFunctionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ruleEvaluationResultListBox = new System.Windows.Forms.ListBox();
            this.fuzzificationResultListBox = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputValuesGrid)).BeginInit();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membershipFunctionChart)).BeginInit();
            this.resultsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aggregatedFunctionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainTabPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Controls.Add(this.resultsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(883, 661);
            this.tabControl.TabIndex = 0;
            // 
            // mainTabPage
            // 
            this.mainTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTabPage.Controls.Add(this.rulesLabel);
            this.mainTabPage.Controls.Add(this.inputValuesLabel);
            this.mainTabPage.Controls.Add(this.rulesListBox);
            this.mainTabPage.Controls.Add(this.inputValuesGrid);
            this.mainTabPage.Controls.Add(this.calculateButton);
            this.mainTabPage.Controls.Add(this.decisionTypeLabel);
            this.mainTabPage.Controls.Add(this.decisionTypeComboBox);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(875, 635);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Dane";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // rulesLabel
            // 
            this.rulesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Location = new System.Drawing.Point(46, 387);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(115, 13);
            this.rulesLabel.TabIndex = 12;
            this.rulesLabel.Text = "Reguły wnioskowania:";
            // 
            // inputValuesLabel
            // 
            this.inputValuesLabel.AutoSize = true;
            this.inputValuesLabel.Location = new System.Drawing.Point(46, 70);
            this.inputValuesLabel.Name = "inputValuesLabel";
            this.inputValuesLabel.Size = new System.Drawing.Size(104, 13);
            this.inputValuesLabel.TabIndex = 11;
            this.inputValuesLabel.Text = "Wartości wejściowe:";
            // 
            // rulesListBox
            // 
            this.rulesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesListBox.FormattingEnabled = true;
            this.rulesListBox.Location = new System.Drawing.Point(49, 403);
            this.rulesListBox.Name = "rulesListBox";
            this.rulesListBox.Size = new System.Drawing.Size(771, 173);
            this.rulesListBox.TabIndex = 10;
            // 
            // inputValuesGrid
            // 
            this.inputValuesGrid.AllowUserToAddRows = false;
            this.inputValuesGrid.AllowUserToDeleteRows = false;
            this.inputValuesGrid.AllowUserToResizeRows = false;
            this.inputValuesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputValuesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inputValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputValuesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linguisticVariableNameColumn,
            this.linguisticVariableValueColumn,
            this.linguisticVariableUnitColumn});
            this.inputValuesGrid.Location = new System.Drawing.Point(49, 86);
            this.inputValuesGrid.Name = "inputValuesGrid";
            this.inputValuesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inputValuesGrid.Size = new System.Drawing.Size(771, 295);
            this.inputValuesGrid.TabIndex = 9;
            this.inputValuesGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputValuesGrid_CellEndEdit);
            this.inputValuesGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.inputValuesGrid_CellValidating);
            // 
            // linguisticVariableNameColumn
            // 
            this.linguisticVariableNameColumn.HeaderText = "Nazwa";
            this.linguisticVariableNameColumn.Name = "linguisticVariableNameColumn";
            this.linguisticVariableNameColumn.ReadOnly = true;
            // 
            // linguisticVariableValueColumn
            // 
            this.linguisticVariableValueColumn.HeaderText = "Wartość";
            this.linguisticVariableValueColumn.Name = "linguisticVariableValueColumn";
            this.linguisticVariableValueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // linguisticVariableUnitColumn
            // 
            this.linguisticVariableUnitColumn.HeaderText = "Jednostka";
            this.linguisticVariableUnitColumn.Name = "linguisticVariableUnitColumn";
            this.linguisticVariableUnitColumn.ReadOnly = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.calculateButton.Location = new System.Drawing.Point(392, 592);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // decisionTypeLabel
            // 
            this.decisionTypeLabel.AutoSize = true;
            this.decisionTypeLabel.Location = new System.Drawing.Point(46, 23);
            this.decisionTypeLabel.Name = "decisionTypeLabel";
            this.decisionTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.decisionTypeLabel.TabIndex = 1;
            this.decisionTypeLabel.Text = "Typ decyzji:";
            // 
            // decisionTypeComboBox
            // 
            this.decisionTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decisionTypeComboBox.FormattingEnabled = true;
            this.decisionTypeComboBox.Location = new System.Drawing.Point(49, 39);
            this.decisionTypeComboBox.Name = "decisionTypeComboBox";
            this.decisionTypeComboBox.Size = new System.Drawing.Size(771, 21);
            this.decisionTypeComboBox.TabIndex = 0;
            this.decisionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.decisionTypeComboBox_SelectedIndexChanged);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.splitContainer1);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(875, 635);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Ustawienia";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.variablesTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.invertTrapezoidCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.membershipFunctionChart);
            this.splitContainer1.Panel2.Controls.Add(this.x4UnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x3UnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x2UnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x1UnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x4ValueTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.x4Label);
            this.splitContainer1.Panel2.Controls.Add(this.x3ValueTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.x3Label);
            this.splitContainer1.Panel2.Controls.Add(this.x2ValueTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.x2Label);
            this.splitContainer1.Panel2.Controls.Add(this.x1ValueTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.x1Label);
            this.splitContainer1.Size = new System.Drawing.Size(869, 629);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 0;
            // 
            // variablesTreeView
            // 
            this.variablesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variablesTreeView.Location = new System.Drawing.Point(0, 0);
            this.variablesTreeView.Name = "variablesTreeView";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Młody";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Średni";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Stary";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Wiek";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Małe";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Średnie";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Wysokie";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Średnie miesięczne wpływy";
            this.variablesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.variablesTreeView.Size = new System.Drawing.Size(152, 629);
            this.variablesTreeView.TabIndex = 0;
            this.variablesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.variablesTreeView_AfterSelect);
            // 
            // invertTrapezoidCheckbox
            // 
            this.invertTrapezoidCheckbox.AutoSize = true;
            this.invertTrapezoidCheckbox.Location = new System.Drawing.Point(36, 143);
            this.invertTrapezoidCheckbox.Name = "invertTrapezoidCheckbox";
            this.invertTrapezoidCheckbox.Size = new System.Drawing.Size(112, 17);
            this.invertTrapezoidCheckbox.TabIndex = 17;
            this.invertTrapezoidCheckbox.Text = "Odwrócony trapez";
            this.invertTrapezoidCheckbox.UseVisualStyleBackColor = true;
            this.invertTrapezoidCheckbox.CheckedChanged += new System.EventHandler(this.invertTrapezoidCheckbox_CheckedChanged);
            // 
            // membershipFunctionChart
            // 
            this.membershipFunctionChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.membershipFunctionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.membershipFunctionChart.Legends.Add(legend1);
            this.membershipFunctionChart.Location = new System.Drawing.Point(14, 157);
            this.membershipFunctionChart.Name = "membershipFunctionChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            this.membershipFunctionChart.Series.Add(series1);
            this.membershipFunctionChart.Size = new System.Drawing.Size(694, 467);
            this.membershipFunctionChart.TabIndex = 16;
            this.membershipFunctionChart.Text = "membershipFunctionChart";
            // 
            // x4UnitLabel
            // 
            this.x4UnitLabel.AutoSize = true;
            this.x4UnitLabel.Location = new System.Drawing.Point(166, 111);
            this.x4UnitLabel.Name = "x4UnitLabel";
            this.x4UnitLabel.Size = new System.Drawing.Size(24, 13);
            this.x4UnitLabel.TabIndex = 15;
            this.x4UnitLabel.Text = "lata";
            // 
            // x3UnitLabel
            // 
            this.x3UnitLabel.AutoSize = true;
            this.x3UnitLabel.Location = new System.Drawing.Point(166, 79);
            this.x3UnitLabel.Name = "x3UnitLabel";
            this.x3UnitLabel.Size = new System.Drawing.Size(24, 13);
            this.x3UnitLabel.TabIndex = 14;
            this.x3UnitLabel.Text = "lata";
            // 
            // x2UnitLabel
            // 
            this.x2UnitLabel.AutoSize = true;
            this.x2UnitLabel.Location = new System.Drawing.Point(166, 45);
            this.x2UnitLabel.Name = "x2UnitLabel";
            this.x2UnitLabel.Size = new System.Drawing.Size(24, 13);
            this.x2UnitLabel.TabIndex = 13;
            this.x2UnitLabel.Text = "lata";
            // 
            // x1UnitLabel
            // 
            this.x1UnitLabel.AutoSize = true;
            this.x1UnitLabel.Location = new System.Drawing.Point(166, 12);
            this.x1UnitLabel.Name = "x1UnitLabel";
            this.x1UnitLabel.Size = new System.Drawing.Size(24, 13);
            this.x1UnitLabel.TabIndex = 12;
            this.x1UnitLabel.Text = "lata";
            // 
            // x4ValueTextBox
            // 
            this.x4ValueTextBox.Location = new System.Drawing.Point(107, 108);
            this.x4ValueTextBox.Name = "x4ValueTextBox";
            this.x4ValueTextBox.Size = new System.Drawing.Size(53, 20);
            this.x4ValueTextBox.TabIndex = 11;
            this.x4ValueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.xValueTextBox_Validating);
            this.x4ValueTextBox.Validated += new System.EventHandler(this.x4ValueTextBox_Validated);
            // 
            // x4Label
            // 
            this.x4Label.AutoSize = true;
            this.x4Label.Location = new System.Drawing.Point(33, 111);
            this.x4Label.Name = "x4Label";
            this.x4Label.Size = new System.Drawing.Size(68, 13);
            this.x4Label.TabIndex = 10;
            this.x4Label.Text = "x4 (prawe 0):";
            // 
            // x3ValueTextBox
            // 
            this.x3ValueTextBox.Location = new System.Drawing.Point(107, 76);
            this.x3ValueTextBox.Name = "x3ValueTextBox";
            this.x3ValueTextBox.Size = new System.Drawing.Size(53, 20);
            this.x3ValueTextBox.TabIndex = 9;
            this.x3ValueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.xValueTextBox_Validating);
            this.x3ValueTextBox.Validated += new System.EventHandler(this.x3ValueTextBox_Validated);
            // 
            // x3Label
            // 
            this.x3Label.AutoSize = true;
            this.x3Label.Location = new System.Drawing.Point(33, 79);
            this.x3Label.Name = "x3Label";
            this.x3Label.Size = new System.Drawing.Size(68, 13);
            this.x3Label.TabIndex = 8;
            this.x3Label.Text = "x3 (prawa 1):";
            // 
            // x2ValueTextBox
            // 
            this.x2ValueTextBox.Location = new System.Drawing.Point(107, 42);
            this.x2ValueTextBox.Name = "x2ValueTextBox";
            this.x2ValueTextBox.Size = new System.Drawing.Size(53, 20);
            this.x2ValueTextBox.TabIndex = 7;
            this.x2ValueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.xValueTextBox_Validating);
            this.x2ValueTextBox.Validated += new System.EventHandler(this.x2ValueTextBox_Validated);
            // 
            // x2Label
            // 
            this.x2Label.AutoSize = true;
            this.x2Label.Location = new System.Drawing.Point(33, 45);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(61, 13);
            this.x2Label.TabIndex = 6;
            this.x2Label.Text = "x2 (lewa 1):";
            // 
            // x1ValueTextBox
            // 
            this.x1ValueTextBox.Location = new System.Drawing.Point(107, 9);
            this.x1ValueTextBox.Name = "x1ValueTextBox";
            this.x1ValueTextBox.Size = new System.Drawing.Size(53, 20);
            this.x1ValueTextBox.TabIndex = 5;
            this.x1ValueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.xValueTextBox_Validating);
            this.x1ValueTextBox.Validated += new System.EventHandler(this.x1ValueTextBox_Validated);
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Location = new System.Drawing.Point(33, 12);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(61, 13);
            this.x1Label.TabIndex = 4;
            this.x1Label.Text = "x1 (lewe 0):";
            // 
            // resultsTabPage
            // 
            this.resultsTabPage.Controls.Add(this.evaluationResultLabel);
            this.resultsTabPage.Controls.Add(this.fuzzificationResultsLabel);
            this.resultsTabPage.Controls.Add(this.aggregatedFunctionChart);
            this.resultsTabPage.Controls.Add(this.ruleEvaluationResultListBox);
            this.resultsTabPage.Controls.Add(this.fuzzificationResultListBox);
            this.resultsTabPage.Location = new System.Drawing.Point(4, 22);
            this.resultsTabPage.Name = "resultsTabPage";
            this.resultsTabPage.Size = new System.Drawing.Size(875, 635);
            this.resultsTabPage.TabIndex = 2;
            this.resultsTabPage.Text = "Wnioskowanie";
            this.resultsTabPage.UseVisualStyleBackColor = true;
            // 
            // evaluationResultLabel
            // 
            this.evaluationResultLabel.AutoSize = true;
            this.evaluationResultLabel.Location = new System.Drawing.Point(41, 126);
            this.evaluationResultLabel.Name = "evaluationResultLabel";
            this.evaluationResultLabel.Size = new System.Drawing.Size(165, 13);
            this.evaluationResultLabel.TabIndex = 4;
            this.evaluationResultLabel.Text = "Wnioskowanie (ewaluacja reguł):";
            // 
            // fuzzificationResultsLabel
            // 
            this.fuzzificationResultsLabel.AutoSize = true;
            this.fuzzificationResultsLabel.Location = new System.Drawing.Point(44, 9);
            this.fuzzificationResultsLabel.Name = "fuzzificationResultsLabel";
            this.fuzzificationResultsLabel.Size = new System.Drawing.Size(70, 13);
            this.fuzzificationResultsLabel.TabIndex = 3;
            this.fuzzificationResultsLabel.Text = "Rozmywanie:";
            // 
            // aggregatedFunctionChart
            // 
            this.aggregatedFunctionChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisY.Maximum = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.aggregatedFunctionChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.aggregatedFunctionChart.Legends.Add(legend2);
            this.aggregatedFunctionChart.Location = new System.Drawing.Point(44, 250);
            this.aggregatedFunctionChart.Margin = new System.Windows.Forms.Padding(0);
            this.aggregatedFunctionChart.Name = "aggregatedFunctionChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.aggregatedFunctionChart.Series.Add(series2);
            this.aggregatedFunctionChart.Size = new System.Drawing.Size(688, 356);
            this.aggregatedFunctionChart.TabIndex = 2;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "aggregatedFunctionChartTitle";
            this.aggregatedFunctionChart.Titles.Add(title1);
            // 
            // ruleEvaluationResultListBox
            // 
            this.ruleEvaluationResultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ruleEvaluationResultListBox.FormattingEnabled = true;
            this.ruleEvaluationResultListBox.Location = new System.Drawing.Point(44, 142);
            this.ruleEvaluationResultListBox.Name = "ruleEvaluationResultListBox";
            this.ruleEvaluationResultListBox.Size = new System.Drawing.Size(688, 95);
            this.ruleEvaluationResultListBox.TabIndex = 1;
            // 
            // fuzzificationResultListBox
            // 
            this.fuzzificationResultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fuzzificationResultListBox.FormattingEnabled = true;
            this.fuzzificationResultListBox.Location = new System.Drawing.Point(44, 28);
            this.fuzzificationResultListBox.Name = "fuzzificationResultListBox";
            this.fuzzificationResultListBox.Size = new System.Drawing.Size(688, 95);
            this.fuzzificationResultListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 661);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Wnioskowanie";
            this.tabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputValuesGrid)).EndInit();
            this.settingsTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membershipFunctionChart)).EndInit();
            this.resultsTabPage.ResumeLayout(false);
            this.resultsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aggregatedFunctionChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.Label decisionTypeLabel;
        private System.Windows.Forms.ComboBox decisionTypeComboBox;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView variablesTreeView;
        private System.Windows.Forms.TextBox x4ValueTextBox;
        private System.Windows.Forms.Label x4Label;
        private System.Windows.Forms.TextBox x3ValueTextBox;
        private System.Windows.Forms.Label x3Label;
        private System.Windows.Forms.TextBox x2ValueTextBox;
        private System.Windows.Forms.Label x2Label;
        private System.Windows.Forms.TextBox x1ValueTextBox;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.Label x4UnitLabel;
        private System.Windows.Forms.Label x3UnitLabel;
        private System.Windows.Forms.Label x2UnitLabel;
        private System.Windows.Forms.Label x1UnitLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart membershipFunctionChart;
        private System.Windows.Forms.DataGridView inputValuesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn linguisticVariableNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linguisticVariableValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linguisticVariableUnitColumn;
        private System.Windows.Forms.ListBox rulesListBox;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Label inputValuesLabel;
        private System.Windows.Forms.TabPage resultsTabPage;
        private System.Windows.Forms.ListBox fuzzificationResultListBox;
        private System.Windows.Forms.ListBox ruleEvaluationResultListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart aggregatedFunctionChart;
        private System.Windows.Forms.Label evaluationResultLabel;
        private System.Windows.Forms.Label fuzzificationResultsLabel;
        private System.Windows.Forms.CheckBox invertTrapezoidCheckbox;
    }
}

