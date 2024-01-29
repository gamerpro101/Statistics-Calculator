
namespace StatsWithGUI
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
            this.components = new System.ComponentModel.Container();
            this.theList = new System.Windows.Forms.ListBox();
            this.addGB = new System.Windows.Forms.GroupBox();
            this.addNumber = new System.Windows.Forms.Button();
            this.frequencyOnOff = new System.Windows.Forms.CheckBox();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.numberToAdd = new System.Windows.Forms.NumericUpDown();
            this.numberLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.removeGB = new System.Windows.Forms.GroupBox();
            this.clearList = new System.Windows.Forms.Button();
            this.removeSelected = new System.Windows.Forms.Button();
            this.resultsGB = new System.Windows.Forms.GroupBox();
            this.sdTextBox = new System.Windows.Forms.TextBox();
            this.meanTextBox = new System.Windows.Forms.TextBox();
            this.sdLabel = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.iqrLabel = new System.Windows.Forms.Label();
            this.q3Label = new System.Windows.Forms.Label();
            this.q1Label = new System.Windows.Forms.Label();
            this.iqrTextBox = new System.Windows.Forms.TextBox();
            this.q3TextBox = new System.Windows.Forms.TextBox();
            this.q1TextBox = new System.Windows.Forms.TextBox();
            this.medianTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.medianLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.mode2 = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.mode1 = new System.Windows.Forms.RadioButton();
            this.nLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.histogramContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.importButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.exportButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.streamGB = new System.Windows.Forms.GroupBox();
            this.importWithoutReplacement = new System.Windows.Forms.CheckBox();
            this.exportType = new System.Windows.Forms.ComboBox();
            this.exportTypeLabel = new System.Windows.Forms.Label();
            this.selectedGB = new System.Windows.Forms.GroupBox();
            this.percentileTextBox = new System.Windows.Forms.TextBox();
            this.zscoreTextbox = new System.Windows.Forms.TextBox();
            this.pLabel = new System.Windows.Forms.Label();
            this.zscoreLabel = new System.Windows.Forms.Label();
            this.addGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberToAdd)).BeginInit();
            this.removeGB.SuspendLayout();
            this.resultsGB.SuspendLayout();
            this.histogramContainer.SuspendLayout();
            this.streamGB.SuspendLayout();
            this.selectedGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // theList
            // 
            this.theList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theList.FormattingEnabled = true;
            this.theList.Location = new System.Drawing.Point(12, 12);
            this.theList.Name = "theList";
            this.theList.Size = new System.Drawing.Size(285, 472);
            this.theList.TabIndex = 0;
            // 
            // addGB
            // 
            this.addGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addGB.Controls.Add(this.addNumber);
            this.addGB.Controls.Add(this.frequencyOnOff);
            this.addGB.Controls.Add(this.frequency);
            this.addGB.Controls.Add(this.numberToAdd);
            this.addGB.Controls.Add(this.numberLabel);
            this.addGB.Location = new System.Drawing.Point(303, 12);
            this.addGB.Name = "addGB";
            this.addGB.Size = new System.Drawing.Size(224, 100);
            this.addGB.TabIndex = 1;
            this.addGB.TabStop = false;
            this.addGB.Text = "Add";
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(9, 68);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(208, 23);
            this.addNumber.TabIndex = 5;
            this.addNumber.Text = "Add number to list";
            this.addNumber.UseVisualStyleBackColor = true;
            this.addNumber.Click += new System.EventHandler(this.addNumber_Click);
            // 
            // frequencyOnOff
            // 
            this.frequencyOnOff.AutoSize = true;
            this.frequencyOnOff.Location = new System.Drawing.Point(10, 42);
            this.frequencyOnOff.Name = "frequencyOnOff";
            this.frequencyOnOff.Size = new System.Drawing.Size(79, 17);
            this.frequencyOnOff.TabIndex = 4;
            this.frequencyOnOff.Text = "Frequency:";
            this.frequencyOnOff.UseVisualStyleBackColor = true;
            this.frequencyOnOff.CheckedChanged += new System.EventHandler(this.frequencyOnOff_CheckedChanged);
            // 
            // frequency
            // 
            this.frequency.Enabled = false;
            this.frequency.Location = new System.Drawing.Point(93, 41);
            this.frequency.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(123, 20);
            this.frequency.TabIndex = 3;
            this.frequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequency.ValueChanged += new System.EventHandler(this.frequency_ValueChanged);
            // 
            // numberToAdd
            // 
            this.numberToAdd.Location = new System.Drawing.Point(93, 18);
            this.numberToAdd.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numberToAdd.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numberToAdd.Name = "numberToAdd";
            this.numberToAdd.Size = new System.Drawing.Size(123, 20);
            this.numberToAdd.TabIndex = 2;
            this.numberToAdd.ValueChanged += new System.EventHandler(this.numberToAdd_ValueChanged);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(6, 20);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(80, 13);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Number to add:";
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.Location = new System.Drawing.Point(478, 764);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(50, 23);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // removeGB
            // 
            this.removeGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeGB.Controls.Add(this.clearList);
            this.removeGB.Controls.Add(this.removeSelected);
            this.removeGB.Location = new System.Drawing.Point(303, 118);
            this.removeGB.Name = "removeGB";
            this.removeGB.Size = new System.Drawing.Size(224, 81);
            this.removeGB.TabIndex = 3;
            this.removeGB.TabStop = false;
            this.removeGB.Text = "Remove";
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(9, 47);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(208, 23);
            this.clearList.TabIndex = 1;
            this.clearList.Text = "Clear list entirely";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // removeSelected
            // 
            this.removeSelected.Location = new System.Drawing.Point(9, 17);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(208, 23);
            this.removeSelected.TabIndex = 0;
            this.removeSelected.Text = "Remove selected number";
            this.removeSelected.UseVisualStyleBackColor = true;
            this.removeSelected.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // resultsGB
            // 
            this.resultsGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGB.Controls.Add(this.sdTextBox);
            this.resultsGB.Controls.Add(this.meanTextBox);
            this.resultsGB.Controls.Add(this.sdLabel);
            this.resultsGB.Controls.Add(this.meanLabel);
            this.resultsGB.Controls.Add(this.iqrLabel);
            this.resultsGB.Controls.Add(this.q3Label);
            this.resultsGB.Controls.Add(this.q1Label);
            this.resultsGB.Controls.Add(this.iqrTextBox);
            this.resultsGB.Controls.Add(this.q3TextBox);
            this.resultsGB.Controls.Add(this.q1TextBox);
            this.resultsGB.Controls.Add(this.medianTextBox);
            this.resultsGB.Controls.Add(this.sumTextBox);
            this.resultsGB.Controls.Add(this.medianLabel);
            this.resultsGB.Controls.Add(this.sumLabel);
            this.resultsGB.Controls.Add(this.nTextBox);
            this.resultsGB.Controls.Add(this.mode2);
            this.resultsGB.Controls.Add(this.calculate);
            this.resultsGB.Controls.Add(this.mode1);
            this.resultsGB.Controls.Add(this.nLabel);
            this.resultsGB.Location = new System.Drawing.Point(303, 206);
            this.resultsGB.Name = "resultsGB";
            this.resultsGB.Size = new System.Drawing.Size(224, 279);
            this.resultsGB.TabIndex = 4;
            this.resultsGB.TabStop = false;
            this.resultsGB.Text = "Results";
            // 
            // sdTextBox
            // 
            this.sdTextBox.Location = new System.Drawing.Point(116, 222);
            this.sdTextBox.Name = "sdTextBox";
            this.sdTextBox.ReadOnly = true;
            this.sdTextBox.Size = new System.Drawing.Size(100, 20);
            this.sdTextBox.TabIndex = 22;
            // 
            // meanTextBox
            // 
            this.meanTextBox.Location = new System.Drawing.Point(116, 196);
            this.meanTextBox.Name = "meanTextBox";
            this.meanTextBox.ReadOnly = true;
            this.meanTextBox.Size = new System.Drawing.Size(100, 20);
            this.meanTextBox.TabIndex = 21;
            // 
            // sdLabel
            // 
            this.sdLabel.AutoSize = true;
            this.sdLabel.Location = new System.Drawing.Point(6, 225);
            this.sdLabel.Name = "sdLabel";
            this.sdLabel.Size = new System.Drawing.Size(103, 13);
            this.sdLabel.TabIndex = 20;
            this.sdLabel.Text = "standard deviation =";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Location = new System.Drawing.Point(7, 199);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(42, 13);
            this.meanLabel.TabIndex = 19;
            this.meanLabel.Text = "mean =";
            // 
            // iqrLabel
            // 
            this.iqrLabel.AutoSize = true;
            this.iqrLabel.Location = new System.Drawing.Point(6, 251);
            this.iqrLabel.Name = "iqrLabel";
            this.iqrLabel.Size = new System.Drawing.Size(100, 13);
            this.iqrLabel.TabIndex = 18;
            this.iqrLabel.Text = "interquartile range =";
            // 
            // q3Label
            // 
            this.q3Label.AutoSize = true;
            this.q3Label.Location = new System.Drawing.Point(7, 173);
            this.q3Label.Name = "q3Label";
            this.q3Label.Size = new System.Drawing.Size(73, 13);
            this.q3Label.TabIndex = 17;
            this.q3Label.Text = "third quartile =";
            // 
            // q1Label
            // 
            this.q1Label.AutoSize = true;
            this.q1Label.Location = new System.Drawing.Point(7, 121);
            this.q1Label.Name = "q1Label";
            this.q1Label.Size = new System.Drawing.Size(72, 13);
            this.q1Label.TabIndex = 16;
            this.q1Label.Text = "first quartile = ";
            // 
            // iqrTextBox
            // 
            this.iqrTextBox.Location = new System.Drawing.Point(116, 248);
            this.iqrTextBox.Name = "iqrTextBox";
            this.iqrTextBox.ReadOnly = true;
            this.iqrTextBox.Size = new System.Drawing.Size(100, 20);
            this.iqrTextBox.TabIndex = 15;
            // 
            // q3TextBox
            // 
            this.q3TextBox.Location = new System.Drawing.Point(116, 170);
            this.q3TextBox.Name = "q3TextBox";
            this.q3TextBox.ReadOnly = true;
            this.q3TextBox.Size = new System.Drawing.Size(100, 20);
            this.q3TextBox.TabIndex = 14;
            // 
            // q1TextBox
            // 
            this.q1TextBox.Location = new System.Drawing.Point(116, 118);
            this.q1TextBox.Name = "q1TextBox";
            this.q1TextBox.ReadOnly = true;
            this.q1TextBox.Size = new System.Drawing.Size(100, 20);
            this.q1TextBox.TabIndex = 13;
            // 
            // medianTextBox
            // 
            this.medianTextBox.Location = new System.Drawing.Point(116, 144);
            this.medianTextBox.Name = "medianTextBox";
            this.medianTextBox.ReadOnly = true;
            this.medianTextBox.Size = new System.Drawing.Size(100, 20);
            this.medianTextBox.TabIndex = 10;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(116, 92);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.ReadOnly = true;
            this.sumTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumTextBox.TabIndex = 9;
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Location = new System.Drawing.Point(7, 147);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(53, 13);
            this.medianLabel.TabIndex = 6;
            this.medianLabel.Text = "median = ";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(7, 95);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(35, 13);
            this.sumLabel.TabIndex = 5;
            this.sumLabel.Text = "sum =";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(116, 66);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.ReadOnly = true;
            this.nTextBox.Size = new System.Drawing.Size(100, 20);
            this.nTextBox.TabIndex = 4;
            // 
            // mode2
            // 
            this.mode2.AutoSize = true;
            this.mode2.Location = new System.Drawing.Point(10, 42);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(122, 17);
            this.mode2.TabIndex = 3;
            this.mode2.Text = "Calculate in real time";
            this.toolTip1.SetToolTip(this.mode2, "Not recommended on low-end computers.");
            this.mode2.UseVisualStyleBackColor = true;
            this.mode2.CheckedChanged += new System.EventHandler(this.mode2_CheckedChanged);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(141, 17);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(76, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // mode1
            // 
            this.mode1.AutoSize = true;
            this.mode1.Checked = true;
            this.mode1.Location = new System.Drawing.Point(10, 20);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(112, 17);
            this.mode1.TabIndex = 1;
            this.mode1.TabStop = true;
            this.mode1.Text = "Calculate on click:";
            this.mode1.UseVisualStyleBackColor = true;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(7, 69);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(25, 13);
            this.nLabel.TabIndex = 0;
            this.nLabel.Text = "n = ";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // The interval used to be 1, but I changed it down to 50 so less resources are used.
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // histogramContainer
            // 
            this.histogramContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramContainer.Controls.Add(this.label1);
            this.histogramContainer.Location = new System.Drawing.Point(12, 570);
            this.histogramContainer.Name = "histogramContainer";
            this.histogramContainer.Size = new System.Drawing.Size(515, 188);
            this.histogramContainer.TabIndex = 5;
            this.toolTip1.SetToolTip(this.histogramContainer, "I plan to make a histogram calculator. It\'s still a WIP.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not implemented yet...";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(9, 17);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(67, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Import list";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(9, 43);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(67, 23);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "Export list";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text file|*.txt|All|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // streamGB
            // 
            this.streamGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streamGB.Controls.Add(this.importWithoutReplacement);
            this.streamGB.Controls.Add(this.exportType);
            this.streamGB.Controls.Add(this.exportTypeLabel);
            this.streamGB.Controls.Add(this.importButton);
            this.streamGB.Controls.Add(this.exportButton);
            this.streamGB.Location = new System.Drawing.Point(12, 489);
            this.streamGB.Name = "streamGB";
            this.streamGB.Size = new System.Drawing.Size(285, 75);
            this.streamGB.TabIndex = 8;
            this.streamGB.TabStop = false;
            this.streamGB.Text = "Import/export";
            // 
            // importWithoutReplacement
            // 
            this.importWithoutReplacement.AutoSize = true;
            this.importWithoutReplacement.Location = new System.Drawing.Point(84, 21);
            this.importWithoutReplacement.Name = "importWithoutReplacement";
            this.importWithoutReplacement.Size = new System.Drawing.Size(177, 17);
            this.importWithoutReplacement.TabIndex = 10;
            this.importWithoutReplacement.Text = "Do not clear list before importing";
            this.importWithoutReplacement.UseVisualStyleBackColor = true;
            // 
            // exportType
            // 
            this.exportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exportType.FormattingEnabled = true;
            this.exportType.Items.AddRange(new object[] {
            "One line, commas",
            "New line for each item"});
            this.exportType.Location = new System.Drawing.Point(150, 45);
            this.exportType.Name = "exportType";
            this.exportType.Size = new System.Drawing.Size(129, 21);
            this.exportType.TabIndex = 9;
            // 
            // exportTypeLabel
            // 
            this.exportTypeLabel.AutoSize = true;
            this.exportTypeLabel.Location = new System.Drawing.Point(81, 48);
            this.exportTypeLabel.Name = "exportTypeLabel";
            this.exportTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.exportTypeLabel.TabIndex = 8;
            this.exportTypeLabel.Text = "Export type:";
            // 
            // selectedGB
            // 
            this.selectedGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedGB.Controls.Add(this.percentileTextBox);
            this.selectedGB.Controls.Add(this.zscoreTextbox);
            this.selectedGB.Controls.Add(this.pLabel);
            this.selectedGB.Controls.Add(this.zscoreLabel);
            this.selectedGB.Location = new System.Drawing.Point(303, 489);
            this.selectedGB.Name = "selectedGB";
            this.selectedGB.Size = new System.Drawing.Size(224, 75);
            this.selectedGB.TabIndex = 9;
            this.selectedGB.TabStop = false;
            this.selectedGB.Text = "Results for selected item";
            // 
            // percentileTextBox
            // 
            this.percentileTextBox.Location = new System.Drawing.Point(116, 45);
            this.percentileTextBox.Name = "percentileTextBox";
            this.percentileTextBox.ReadOnly = true;
            this.percentileTextBox.Size = new System.Drawing.Size(100, 20);
            this.percentileTextBox.TabIndex = 3;
            // 
            // zscoreTextbox
            // 
            this.zscoreTextbox.Location = new System.Drawing.Point(116, 19);
            this.zscoreTextbox.Name = "zscoreTextbox";
            this.zscoreTextbox.ReadOnly = true;
            this.zscoreTextbox.Size = new System.Drawing.Size(100, 20);
            this.zscoreTextbox.TabIndex = 2;
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(7, 48);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(65, 13);
            this.pLabel.TabIndex = 1;
            this.pLabel.Text = "percentile = ";
            // 
            // zscoreLabel
            // 
            this.zscoreLabel.AutoSize = true;
            this.zscoreLabel.Location = new System.Drawing.Point(7, 22);
            this.zscoreLabel.Name = "zscoreLabel";
            this.zscoreLabel.Size = new System.Drawing.Size(50, 13);
            this.zscoreLabel.TabIndex = 0;
            this.zscoreLabel.Text = "z score =";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 799);
            this.Controls.Add(this.selectedGB);
            this.Controls.Add(this.streamGB);
            this.Controls.Add(this.histogramContainer);
            this.Controls.Add(this.resultsGB);
            this.Controls.Add(this.removeGB);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.addGB);
            this.Controls.Add(this.theList);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Statistics Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.addGB.ResumeLayout(false);
            this.addGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberToAdd)).EndInit();
            this.removeGB.ResumeLayout(false);
            this.resultsGB.ResumeLayout(false);
            this.resultsGB.PerformLayout();
            this.histogramContainer.ResumeLayout(false);
            this.histogramContainer.PerformLayout();
            this.streamGB.ResumeLayout(false);
            this.streamGB.PerformLayout();
            this.selectedGB.ResumeLayout(false);
            this.selectedGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox theList;
        private System.Windows.Forms.GroupBox addGB;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.CheckBox frequencyOnOff;
        private System.Windows.Forms.NumericUpDown frequency;
        private System.Windows.Forms.NumericUpDown numberToAdd;
        private System.Windows.Forms.Button addNumber;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.GroupBox removeGB;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.GroupBox resultsGB;
        private System.Windows.Forms.TextBox medianTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.RadioButton mode2;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.RadioButton mode1;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel histogramContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox streamGB;
        private System.Windows.Forms.ComboBox exportType;
        private System.Windows.Forms.Label exportTypeLabel;
        private System.Windows.Forms.Label iqrLabel;
        private System.Windows.Forms.Label q3Label;
        private System.Windows.Forms.Label q1Label;
        private System.Windows.Forms.TextBox iqrTextBox;
        private System.Windows.Forms.TextBox q3TextBox;
        private System.Windows.Forms.TextBox q1TextBox;
        private System.Windows.Forms.TextBox sdTextBox;
        private System.Windows.Forms.TextBox meanTextBox;
        private System.Windows.Forms.Label sdLabel;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.GroupBox selectedGB;
        private System.Windows.Forms.TextBox percentileTextBox;
        private System.Windows.Forms.TextBox zscoreTextbox;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label zscoreLabel;
        private System.Windows.Forms.CheckBox importWithoutReplacement;
    }
}

