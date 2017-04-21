namespace BPSimplified
{
    partial class NeuralDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuralDemo));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxTrainingBrowse = new System.Windows.Forms.TextBox();
            this.buttonTrainingBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaxError = new System.Windows.Forms.TextBox();
            this.comboBoxLayers = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxInputUnit = new System.Windows.Forms.TextBox();
            this.textBoxOutputUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHiddenUnit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelIteration = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxMatchedPattern = new System.Windows.Forms.GroupBox();
            this.labelMatchedLow = new System.Windows.Forms.Label();
            this.labelMatchedHigh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMatchedLow = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatchedHigh = new System.Windows.Forms.PictureBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxBrowse = new System.Windows.Forms.TextBox();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonBrowse = new System.Windows.Forms.RadioButton();
            this.radioButtonDraw = new System.Windows.Forms.RadioButton();
            this.groupBoxDrawing = new System.Windows.Forms.GroupBox();
            this.drawingPanel1 = new BPSimplified.DrawingPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxMatchedPattern.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchedLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchedHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.groupBoxDrawing.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.buttonSaveSettings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(114, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(288, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Saving the settings requires to (re)train or load the network";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxTrainingBrowse);
            this.groupBox3.Controls.Add(this.buttonTrainingBrowse);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(15, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 73);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Training Images\' Properties";
            // 
            // textBoxTrainingBrowse
            // 
            this.textBoxTrainingBrowse.Location = new System.Drawing.Point(6, 36);
            this.textBoxTrainingBrowse.Name = "textBoxTrainingBrowse";
            this.textBoxTrainingBrowse.Size = new System.Drawing.Size(381, 20);
            this.textBoxTrainingBrowse.TabIndex = 4;
            // 
            // buttonTrainingBrowse
            // 
            this.buttonTrainingBrowse.Location = new System.Drawing.Point(393, 34);
            this.buttonTrainingBrowse.Name = "buttonTrainingBrowse";
            this.buttonTrainingBrowse.Size = new System.Drawing.Size(59, 23);
            this.buttonTrainingBrowse.TabIndex = 3;
            this.buttonTrainingBrowse.Text = "Browse";
            this.buttonTrainingBrowse.UseVisualStyleBackColor = true;
            this.buttonTrainingBrowse.Click += new System.EventHandler(this.buttonTrainingBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "The Directory Where Training Images Exist As Images:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxMaxError);
            this.groupBox1.Controls.Add(this.comboBoxLayers);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBoxInputUnit);
            this.groupBox1.Controls.Add(this.textBoxOutputUnit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxHiddenUnit);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 155);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Properties";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Number of Hidden Unit(For Three Layer Net):";
            // 
            // textBoxMaxError
            // 
            this.textBoxMaxError.Location = new System.Drawing.Point(285, 21);
            this.textBoxMaxError.Name = "textBoxMaxError";
            this.textBoxMaxError.Size = new System.Drawing.Size(43, 20);
            this.textBoxMaxError.TabIndex = 17;
            // 
            // comboBoxLayers
            // 
            this.comboBoxLayers.FormattingEnabled = true;
            this.comboBoxLayers.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxLayers.Location = new System.Drawing.Point(119, 21);
            this.comboBoxLayers.Name = "comboBoxLayers";
            this.comboBoxLayers.Size = new System.Drawing.Size(42, 21);
            this.comboBoxLayers.TabIndex = 1;
            this.comboBoxLayers.SelectedIndexChanged += new System.EventHandler(this.comboBoxLayers_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Number of Input Unit(For Two or Three Layer Net):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(171, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Maximum Error:";
            // 
            // textBoxInputUnit
            // 
            this.textBoxInputUnit.Location = new System.Drawing.Point(285, 56);
            this.textBoxInputUnit.Name = "textBoxInputUnit";
            this.textBoxInputUnit.Size = new System.Drawing.Size(43, 20);
            this.textBoxInputUnit.TabIndex = 12;
            // 
            // textBoxOutputUnit
            // 
            this.textBoxOutputUnit.Location = new System.Drawing.Point(285, 121);
            this.textBoxOutputUnit.Name = "textBoxOutputUnit";
            this.textBoxOutputUnit.Size = new System.Drawing.Size(43, 20);
            this.textBoxOutputUnit.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Layers:";
            // 
            // textBoxHiddenUnit
            // 
            this.textBoxHiddenUnit.Location = new System.Drawing.Point(285, 88);
            this.textBoxHiddenUnit.Name = "textBoxHiddenUnit";
            this.textBoxHiddenUnit.Size = new System.Drawing.Size(43, 20);
            this.textBoxHiddenUnit.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Number of Output Unit:";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(15, 282);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(87, 23);
            this.buttonSaveSettings.TabIndex = 15;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelIteration);
            this.tabPage1.Controls.Add(this.labelTimer);
            this.tabPage1.Controls.Add(this.labelError);
            this.tabPage1.Controls.Add(this.buttonStop);
            this.tabPage1.Controls.Add(this.buttonLoad);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.groupBoxMatchedPattern);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxState);
            this.tabPage1.Controls.Add(this.textBoxBrowse);
            this.tabPage1.Controls.Add(this.buttonRecognize);
            this.tabPage1.Controls.Add(this.buttonTrain);
            this.tabPage1.Controls.Add(this.buttonBrowse);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.radioButtonBrowse);
            this.tabPage1.Controls.Add(this.radioButtonDraw);
            this.tabPage1.Controls.Add(this.groupBoxDrawing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelIteration
            // 
            this.labelIteration.AutoSize = true;
            this.labelIteration.Location = new System.Drawing.Point(262, 176);
            this.labelIteration.Name = "labelIteration";
            this.labelIteration.Size = new System.Drawing.Size(48, 13);
            this.labelIteration.TabIndex = 27;
            this.labelIteration.Text = "Iteration:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(345, 176);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(49, 13);
            this.labelTimer.TabIndex = 26;
            this.labelTimer.Text = "00:00:00";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(191, 176);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(32, 13);
            this.labelError.TabIndex = 25;
            this.labelError.Text = "Error:";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(415, 171);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(86, 23);
            this.buttonStop.TabIndex = 24;
            this.buttonStop.Text = "Stop Training";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(194, 296);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(88, 23);
            this.buttonLoad.TabIndex = 23;
            this.buttonLoad.Text = "Load Network";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(87, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(89, 23);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save Network";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxMatchedPattern
            // 
            this.groupBoxMatchedPattern.Controls.Add(this.labelMatchedLow);
            this.groupBoxMatchedPattern.Controls.Add(this.labelMatchedHigh);
            this.groupBoxMatchedPattern.Controls.Add(this.label2);
            this.groupBoxMatchedPattern.Controls.Add(this.pictureBoxMatchedLow);
            this.groupBoxMatchedPattern.Controls.Add(this.pictureBoxMatchedHigh);
            this.groupBoxMatchedPattern.Controls.Add(this.pictureBoxInput);
            this.groupBoxMatchedPattern.Location = new System.Drawing.Point(194, 200);
            this.groupBoxMatchedPattern.Name = "groupBoxMatchedPattern";
            this.groupBoxMatchedPattern.Size = new System.Drawing.Size(307, 90);
            this.groupBoxMatchedPattern.TabIndex = 21;
            this.groupBoxMatchedPattern.TabStop = false;
            this.groupBoxMatchedPattern.Text = "Matched Patterns";
            // 
            // labelMatchedLow
            // 
            this.labelMatchedLow.AutoSize = true;
            this.labelMatchedLow.Location = new System.Drawing.Point(192, 16);
            this.labelMatchedLow.Name = "labelMatchedLow";
            this.labelMatchedLow.Size = new System.Drawing.Size(75, 13);
            this.labelMatchedLow.TabIndex = 5;
            this.labelMatchedLow.Text = "Matched Low:";
            // 
            // labelMatchedHigh
            // 
            this.labelMatchedHigh.AutoSize = true;
            this.labelMatchedHigh.Location = new System.Drawing.Point(83, 16);
            this.labelMatchedHigh.Name = "labelMatchedHigh";
            this.labelMatchedHigh.Size = new System.Drawing.Size(80, 13);
            this.labelMatchedHigh.TabIndex = 4;
            this.labelMatchedHigh.Text = "Matched Hight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input:";
            // 
            // pictureBoxMatchedLow
            // 
            this.pictureBoxMatchedLow.Location = new System.Drawing.Point(195, 33);
            this.pictureBoxMatchedLow.Name = "pictureBoxMatchedLow";
            this.pictureBoxMatchedLow.Size = new System.Drawing.Size(30, 45);
            this.pictureBoxMatchedLow.TabIndex = 2;
            this.pictureBoxMatchedLow.TabStop = false;
            // 
            // pictureBoxMatchedHigh
            // 
            this.pictureBoxMatchedHigh.Location = new System.Drawing.Point(86, 33);
            this.pictureBoxMatchedHigh.Name = "pictureBoxMatchedHigh";
            this.pictureBoxMatchedHigh.Size = new System.Drawing.Size(30, 45);
            this.pictureBoxMatchedHigh.TabIndex = 1;
            this.pictureBoxMatchedHigh.TabStop = false;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(17, 33);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(31, 45);
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "State:";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(194, 98);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxState.Size = new System.Drawing.Size(307, 60);
            this.textBoxState.TabIndex = 18;
            // 
            // textBoxBrowse
            // 
            this.textBoxBrowse.Enabled = false;
            this.textBoxBrowse.Location = new System.Drawing.Point(194, 42);
            this.textBoxBrowse.Name = "textBoxBrowse";
            this.textBoxBrowse.Size = new System.Drawing.Size(248, 20);
            this.textBoxBrowse.TabIndex = 14;
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Enabled = false;
            this.buttonRecognize.Location = new System.Drawing.Point(415, 296);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(86, 23);
            this.buttonRecognize.TabIndex = 17;
            this.buttonRecognize.Text = "Recognize";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            this.buttonRecognize.Click += new System.EventHandler(this.buttonRecognize_Click);
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(304, 296);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(90, 23);
            this.buttonTrain.TabIndex = 16;
            this.buttonTrain.Text = "Train Network";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Enabled = false;
            this.buttonBrowse.Location = new System.Drawing.Point(448, 40);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(53, 23);
            this.buttonBrowse.TabIndex = 15;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 296);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonBrowse
            // 
            this.radioButtonBrowse.AutoSize = true;
            this.radioButtonBrowse.Location = new System.Drawing.Point(194, 18);
            this.radioButtonBrowse.Name = "radioButtonBrowse";
            this.radioButtonBrowse.Size = new System.Drawing.Size(135, 17);
            this.radioButtonBrowse.TabIndex = 12;
            this.radioButtonBrowse.Text = "Choose Existing Image:";
            this.radioButtonBrowse.UseVisualStyleBackColor = true;
            this.radioButtonBrowse.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonDraw
            // 
            this.radioButtonDraw.AutoSize = true;
            this.radioButtonDraw.Checked = true;
            this.radioButtonDraw.Location = new System.Drawing.Point(6, 18);
            this.radioButtonDraw.Name = "radioButtonDraw";
            this.radioButtonDraw.Size = new System.Drawing.Size(107, 17);
            this.radioButtonDraw.TabIndex = 11;
            this.radioButtonDraw.TabStop = true;
            this.radioButtonDraw.Text = "Draw Characters:";
            this.radioButtonDraw.UseVisualStyleBackColor = true;
            this.radioButtonDraw.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxDrawing
            // 
            this.groupBoxDrawing.Controls.Add(this.drawingPanel1);
            this.groupBoxDrawing.Location = new System.Drawing.Point(6, 41);
            this.groupBoxDrawing.Name = "groupBoxDrawing";
            this.groupBoxDrawing.Size = new System.Drawing.Size(170, 249);
            this.groupBoxDrawing.TabIndex = 10;
            this.groupBoxDrawing.TabStop = false;
            this.groupBoxDrawing.Text = "Drawing Area";
            // 
            // drawingPanel1
            // 
            this.drawingPanel1.BackColor = System.Drawing.Color.White;
            this.drawingPanel1.ImageOnPanel = ((System.Drawing.Bitmap)(resources.GetObject("drawingPanel1.ImageOnPanel")));
            this.drawingPanel1.Location = new System.Drawing.Point(9, 19);
            this.drawingPanel1.Name = "drawingPanel1";
            this.drawingPanel1.PointSize = 18;
            this.drawingPanel1.Size = new System.Drawing.Size(153, 220);
            this.drawingPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 352);
            this.tabControl1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NeuralDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 353);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "NeuralDemo";
            this.Text = "BackPropagation Neural Network For Image Recognition | ver1.3";
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxMatchedPattern.ResumeLayout(false);
            this.groupBoxMatchedPattern.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchedLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchedHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.groupBoxDrawing.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxTrainingBrowse;
        private System.Windows.Forms.Button buttonTrainingBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMaxError;
        private System.Windows.Forms.ComboBox comboBoxLayers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxInputUnit;
        private System.Windows.Forms.TextBox textBoxOutputUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHiddenUnit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxMatchedPattern;
        private System.Windows.Forms.Label labelMatchedLow;
        private System.Windows.Forms.Label labelMatchedHigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxMatchedLow;
        private System.Windows.Forms.PictureBox pictureBoxMatchedHigh;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxBrowse;
        private System.Windows.Forms.Button buttonRecognize;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonBrowse;
        private System.Windows.Forms.RadioButton radioButtonDraw;
        private System.Windows.Forms.GroupBox groupBoxDrawing;
        private System.Windows.Forms.TabControl tabControl1;
        private DrawingPanel drawingPanel1;
        private System.Windows.Forms.Label labelIteration;
        private System.Windows.Forms.Timer timer1;

    }
}

