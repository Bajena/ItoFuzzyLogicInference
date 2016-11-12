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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.inputValuesLabel = new System.Windows.Forms.Label();
            this.rulesListBox = new System.Windows.Forms.ListBox();
            this.inputValuesGrid = new System.Windows.Forms.DataGridView();
            this.linguisticVariableNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linguisticVariableValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linguisticVariableUnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toggleInferenceDetailsCheckbox = new System.Windows.Forms.CheckBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.decisionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.variablesTreeView = new System.Windows.Forms.TreeView();
            this.membershipFunctionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.x4UnitLabel = new System.Windows.Forms.Label();
            this.x3UnitLabel = new System.Windows.Forms.Label();
            this.x2UnitLabel = new System.Windows.Forms.Label();
            this.x1UnitLabel = new System.Windows.Forms.Label();
            this.x4ValueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.x3ValueTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.x2ValueTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.x1ValueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputValuesGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membershipFunctionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rulesLabel);
            this.tabPage1.Controls.Add(this.inputValuesLabel);
            this.tabPage1.Controls.Add(this.rulesListBox);
            this.tabPage1.Controls.Add(this.inputValuesGrid);
            this.tabPage1.Controls.Add(this.toggleInferenceDetailsCheckbox);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.calculateButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.decisionTypeComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Obliczenia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Location = new System.Drawing.Point(46, 251);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(112, 13);
            this.rulesLabel.TabIndex = 12;
            this.rulesLabel.Text = "Reguły wnioskowania";
            // 
            // inputValuesLabel
            // 
            this.inputValuesLabel.AutoSize = true;
            this.inputValuesLabel.Location = new System.Drawing.Point(46, 70);
            this.inputValuesLabel.Name = "inputValuesLabel";
            this.inputValuesLabel.Size = new System.Drawing.Size(101, 13);
            this.inputValuesLabel.TabIndex = 11;
            this.inputValuesLabel.Text = "Wartości wejściowe";
            // 
            // rulesListBox
            // 
            this.rulesListBox.FormattingEnabled = true;
            this.rulesListBox.Location = new System.Drawing.Point(49, 267);
            this.rulesListBox.Name = "rulesListBox";
            this.rulesListBox.Size = new System.Drawing.Size(377, 95);
            this.rulesListBox.TabIndex = 10;
            // 
            // inputValuesGrid
            // 
            this.inputValuesGrid.AllowUserToAddRows = false;
            this.inputValuesGrid.AllowUserToDeleteRows = false;
            this.inputValuesGrid.AllowUserToResizeRows = false;
            this.inputValuesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inputValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputValuesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linguisticVariableNameColumn,
            this.linguisticVariableValueColumn,
            this.linguisticVariableUnitColumn});
            this.inputValuesGrid.Location = new System.Drawing.Point(49, 86);
            this.inputValuesGrid.Name = "inputValuesGrid";
            this.inputValuesGrid.Size = new System.Drawing.Size(377, 160);
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
            // toggleInferenceDetailsCheckbox
            // 
            this.toggleInferenceDetailsCheckbox.AutoSize = true;
            this.toggleInferenceDetailsCheckbox.Location = new System.Drawing.Point(49, 368);
            this.toggleInferenceDetailsCheckbox.Name = "toggleInferenceDetailsCheckbox";
            this.toggleInferenceDetailsCheckbox.Size = new System.Drawing.Size(173, 17);
            this.toggleInferenceDetailsCheckbox.TabIndex = 8;
            this.toggleInferenceDetailsCheckbox.Text = "Wyświetl proces wnioskowania";
            this.toggleInferenceDetailsCheckbox.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(177, 430);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(106, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Wynik to: 300.000 zł";
            this.resultLabel.Visible = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(49, 391);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Typ decyzji";
            // 
            // decisionTypeComboBox
            // 
            this.decisionTypeComboBox.FormattingEnabled = true;
            this.decisionTypeComboBox.Location = new System.Drawing.Point(49, 39);
            this.decisionTypeComboBox.Name = "decisionTypeComboBox";
            this.decisionTypeComboBox.Size = new System.Drawing.Size(377, 21);
            this.decisionTypeComboBox.TabIndex = 0;
            this.decisionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.decisionTypeComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ustawienia";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.membershipFunctionChart);
            this.splitContainer1.Panel2.Controls.Add(this.x4UnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x3UnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x2UnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x1UnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x4ValueTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.x3ValueTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.x2ValueTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.x1ValueTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(460, 465);
            this.splitContainer1.SplitterDistance = 81;
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
            this.variablesTreeView.Size = new System.Drawing.Size(81, 465);
            this.variablesTreeView.TabIndex = 0;
            this.variablesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.variablesTreeView_AfterSelect);
            // 
            // membershipFunctionChart
            // 
            chartArea1.Name = "ChartArea1";
            this.membershipFunctionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.membershipFunctionChart.Legends.Add(legend1);
            this.membershipFunctionChart.Location = new System.Drawing.Point(14, 134);
            this.membershipFunctionChart.Name = "membershipFunctionChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            this.membershipFunctionChart.Series.Add(series1);
            this.membershipFunctionChart.Size = new System.Drawing.Size(368, 300);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "x4 (prawe 0):";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "x3 (prawa 1):";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "x2 (lewa 1):";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "x1 (lewe 0):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Wnioskowanie";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputValuesGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membershipFunctionChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox decisionTypeComboBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox toggleInferenceDetailsCheckbox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView variablesTreeView;
        private System.Windows.Forms.TextBox x4ValueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox x3ValueTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox x2ValueTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox x1ValueTextBox;
        private System.Windows.Forms.Label label5;
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
    }
}

