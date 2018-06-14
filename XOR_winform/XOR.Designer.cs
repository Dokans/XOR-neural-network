namespace XOR_winform
{
    partial class XOR_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iterationCountLabel = new System.Windows.Forms.Label();
            this.iterationNameLabel = new System.Windows.Forms.Label();
            this.NumHLNodes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateNewNN = new System.Windows.Forms.Button();
            this.LabelNNFile = new System.Windows.Forms.Label();
            this.OpenNN = new System.Windows.Forms.OpenFileDialog();
            this.PanelCreateNN = new System.Windows.Forms.Panel();
            this.labelHiddenLayers = new System.Windows.Forms.Label();
            this.numHiddenLayers = new System.Windows.Forms.NumericUpDown();
            this.PanelNNOperator = new System.Windows.Forms.Panel();
            this.BtnSaveNN = new System.Windows.Forms.Button();
            this.BtnStopTraining = new System.Windows.Forms.Button();
            this.BtnTry = new System.Windows.Forms.Button();
            this.BtnTrain = new System.Windows.Forms.Button();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.NumInput2 = new System.Windows.Forms.NumericUpDown();
            this.NumInput1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumLearningRate = new System.Windows.Forms.NumericUpDown();
            this.SaveNN = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumHLNodes)).BeginInit();
            this.PanelCreateNN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHiddenLayers)).BeginInit();
            this.PanelNNOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLearningRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iterationCountLabel);
            this.panel1.Controls.Add(this.iterationNameLabel);
            this.panel1.Location = new System.Drawing.Point(484, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 89);
            this.panel1.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.errorLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabel.Location = new System.Drawing.Point(142, 49);
            this.errorLabel.MaximumSize = new System.Drawing.Size(0, 30);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(16, 17);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "1";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Best error";
            // 
            // iterationCountLabel
            // 
            this.iterationCountLabel.AutoSize = true;
            this.iterationCountLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.iterationCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iterationCountLabel.Location = new System.Drawing.Point(142, 17);
            this.iterationCountLabel.MaximumSize = new System.Drawing.Size(0, 30);
            this.iterationCountLabel.Name = "iterationCountLabel";
            this.iterationCountLabel.Size = new System.Drawing.Size(16, 17);
            this.iterationCountLabel.TabIndex = 1;
            this.iterationCountLabel.Text = "0";
            this.iterationCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iterationNameLabel
            // 
            this.iterationNameLabel.AutoSize = true;
            this.iterationNameLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.iterationNameLabel.Location = new System.Drawing.Point(3, 17);
            this.iterationNameLabel.Name = "iterationNameLabel";
            this.iterationNameLabel.Size = new System.Drawing.Size(129, 17);
            this.iterationNameLabel.TabIndex = 0;
            this.iterationNameLabel.Text = "Number of learning";
            // 
            // NumHLNodes
            // 
            this.NumHLNodes.Location = new System.Drawing.Point(18, 17);
            this.NumHLNodes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumHLNodes.Name = "NumHLNodes";
            this.NumHLNodes.Size = new System.Drawing.Size(61, 22);
            this.NumHLNodes.TabIndex = 1;
            this.NumHLNodes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumHLNodes.ValueChanged += new System.EventHandler(this.NumHLNodes_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "number of neurons id hidden layer(s)";
            // 
            // btnCreateNewNN
            // 
            this.btnCreateNewNN.Enabled = false;
            this.btnCreateNewNN.Location = new System.Drawing.Point(336, 31);
            this.btnCreateNewNN.Name = "btnCreateNewNN";
            this.btnCreateNewNN.Size = new System.Drawing.Size(114, 23);
            this.btnCreateNewNN.TabIndex = 3;
            this.btnCreateNewNN.Text = "Create new NN";
            this.btnCreateNewNN.UseVisualStyleBackColor = true;
            this.btnCreateNewNN.Click += new System.EventHandler(this.BtnCreateNewNN_Click);
            // 
            // LabelNNFile
            // 
            this.LabelNNFile.AutoSize = true;
            this.LabelNNFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelNNFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelNNFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelNNFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelNNFile.Location = new System.Drawing.Point(177, 92);
            this.LabelNNFile.MaximumSize = new System.Drawing.Size(200, 19);
            this.LabelNNFile.Name = "LabelNNFile";
            this.LabelNNFile.Size = new System.Drawing.Size(101, 19);
            this.LabelNNFile.TabIndex = 4;
            this.LabelNNFile.Text = "Use saved NN";
            this.LabelNNFile.Click += new System.EventHandler(this.FileSelect);
            // 
            // OpenNN
            // 
            this.OpenNN.InitialDirectory = "C:/";
            this.OpenNN.Tag = "";
            // 
            // PanelCreateNN
            // 
            this.PanelCreateNN.Controls.Add(this.labelHiddenLayers);
            this.PanelCreateNN.Controls.Add(this.numHiddenLayers);
            this.PanelCreateNN.Controls.Add(this.label2);
            this.PanelCreateNN.Controls.Add(this.NumHLNodes);
            this.PanelCreateNN.Controls.Add(this.LabelNNFile);
            this.PanelCreateNN.Controls.Add(this.btnCreateNewNN);
            this.PanelCreateNN.Location = new System.Drawing.Point(12, 12);
            this.PanelCreateNN.Name = "PanelCreateNN";
            this.PanelCreateNN.Size = new System.Drawing.Size(466, 111);
            this.PanelCreateNN.TabIndex = 6;
            // 
            // labelHiddenLayers
            // 
            this.labelHiddenLayers.AutoSize = true;
            this.labelHiddenLayers.Location = new System.Drawing.Point(88, 47);
            this.labelHiddenLayers.Name = "labelHiddenLayers";
            this.labelHiddenLayers.Size = new System.Drawing.Size(161, 17);
            this.labelHiddenLayers.TabIndex = 7;
            this.labelHiddenLayers.Text = "number of hidden layers";
            // 
            // numHiddenLayers
            // 
            this.numHiddenLayers.Location = new System.Drawing.Point(18, 45);
            this.numHiddenLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHiddenLayers.Name = "numHiddenLayers";
            this.numHiddenLayers.Size = new System.Drawing.Size(61, 22);
            this.numHiddenLayers.TabIndex = 6;
            this.numHiddenLayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PanelNNOperator
            // 
            this.PanelNNOperator.Controls.Add(this.BtnSaveNN);
            this.PanelNNOperator.Controls.Add(this.BtnStopTraining);
            this.PanelNNOperator.Controls.Add(this.BtnTry);
            this.PanelNNOperator.Controls.Add(this.BtnTrain);
            this.PanelNNOperator.Controls.Add(this.LabelOutput);
            this.PanelNNOperator.Controls.Add(this.NumInput2);
            this.PanelNNOperator.Controls.Add(this.NumInput1);
            this.PanelNNOperator.Controls.Add(this.label3);
            this.PanelNNOperator.Controls.Add(this.NumLearningRate);
            this.PanelNNOperator.Enabled = false;
            this.PanelNNOperator.Location = new System.Drawing.Point(12, 160);
            this.PanelNNOperator.Name = "PanelNNOperator";
            this.PanelNNOperator.Size = new System.Drawing.Size(654, 171);
            this.PanelNNOperator.TabIndex = 7;
            // 
            // BtnSaveNN
            // 
            this.BtnSaveNN.Location = new System.Drawing.Point(552, 21);
            this.BtnSaveNN.Name = "BtnSaveNN";
            this.BtnSaveNN.Size = new System.Drawing.Size(80, 125);
            this.BtnSaveNN.TabIndex = 8;
            this.BtnSaveNN.Text = "Save your NN";
            this.BtnSaveNN.UseVisualStyleBackColor = true;
            this.BtnSaveNN.Click += new System.EventHandler(this.BtnSaveNN_Click);
            // 
            // BtnStopTraining
            // 
            this.BtnStopTraining.Enabled = false;
            this.BtnStopTraining.Location = new System.Drawing.Point(73, 113);
            this.BtnStopTraining.Name = "BtnStopTraining";
            this.BtnStopTraining.Size = new System.Drawing.Size(168, 33);
            this.BtnStopTraining.TabIndex = 7;
            this.BtnStopTraining.Text = "Stop training";
            this.BtnStopTraining.UseVisualStyleBackColor = true;
            this.BtnStopTraining.Click += new System.EventHandler(this.BtnStopTraining_Click);
            // 
            // BtnTry
            // 
            this.BtnTry.Location = new System.Drawing.Point(352, 118);
            this.BtnTry.Name = "BtnTry";
            this.BtnTry.Size = new System.Drawing.Size(130, 23);
            this.BtnTry.TabIndex = 6;
            this.BtnTry.Text = "Try NN";
            this.BtnTry.UseVisualStyleBackColor = true;
            this.BtnTry.Click += new System.EventHandler(this.BtnTry_Click);
            // 
            // BtnTrain
            // 
            this.BtnTrain.Location = new System.Drawing.Point(73, 76);
            this.BtnTrain.Name = "BtnTrain";
            this.BtnTrain.Size = new System.Drawing.Size(168, 31);
            this.BtnTrain.TabIndex = 5;
            this.BtnTrain.Text = "Train";
            this.BtnTrain.UseVisualStyleBackColor = true;
            this.BtnTrain.Click += new System.EventHandler(this.BtnTrain_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(477, 50);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(31, 17);
            this.LabelOutput.TabIndex = 4;
            this.LabelOutput.Text = "N/A";
            // 
            // NumInput2
            // 
            this.NumInput2.Location = new System.Drawing.Point(381, 76);
            this.NumInput2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInput2.Name = "NumInput2";
            this.NumInput2.Size = new System.Drawing.Size(45, 22);
            this.NumInput2.TabIndex = 3;
            // 
            // NumInput1
            // 
            this.NumInput1.Location = new System.Drawing.Point(381, 21);
            this.NumInput1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInput1.Name = "NumInput1";
            this.NumInput1.Size = new System.Drawing.Size(45, 22);
            this.NumInput1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Learning Rate";
            // 
            // NumLearningRate
            // 
            this.NumLearningRate.DecimalPlaces = 3;
            this.NumLearningRate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NumLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NumLearningRate.Location = new System.Drawing.Point(73, 48);
            this.NumLearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLearningRate.Name = "NumLearningRate";
            this.NumLearningRate.Size = new System.Drawing.Size(61, 22);
            this.NumLearningRate.TabIndex = 0;
            this.NumLearningRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // SaveNN
            // 
            this.SaveNN.FileName = "nn.bin";
            // 
            // XOR_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(678, 343);
            this.Controls.Add(this.PanelNNOperator);
            this.Controls.Add(this.PanelCreateNN);
            this.Controls.Add(this.panel1);
            this.Name = "XOR_Form";
            this.Text = "XOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumHLNodes)).EndInit();
            this.PanelCreateNN.ResumeLayout(false);
            this.PanelCreateNN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHiddenLayers)).EndInit();
            this.PanelNNOperator.ResumeLayout(false);
            this.PanelNNOperator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLearningRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label iterationNameLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iterationCountLabel;
        private System.Windows.Forms.NumericUpDown NumHLNodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNewNN;
        private System.Windows.Forms.Label LabelNNFile;
        private System.Windows.Forms.OpenFileDialog OpenNN;
        private System.Windows.Forms.Panel PanelCreateNN;
        private System.Windows.Forms.Panel PanelNNOperator;
        public System.Windows.Forms.NumericUpDown NumLearningRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumInput1;
        private System.Windows.Forms.NumericUpDown NumInput2;
        public System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Button BtnTry;
        private System.Windows.Forms.Button BtnTrain;
        private System.Windows.Forms.Button BtnStopTraining;
        private System.Windows.Forms.Label labelHiddenLayers;
        private System.Windows.Forms.NumericUpDown numHiddenLayers;
        private System.Windows.Forms.Button BtnSaveNN;
        private System.Windows.Forms.SaveFileDialog SaveNN;
    }
}