namespace WinForm_.Net_NeuralNetwork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InNeuronA = new TextBox();
            InNeuronB = new TextBox();
            Pr0NeuronA = new TextBox();
            Pr0NeuronB = new TextBox();
            OuNeuronA = new TextBox();
            WeightA = new TextBox();
            WeightB = new TextBox();
            WeightD = new TextBox();
            WeightC = new TextBox();
            WeightF = new TextBox();
            WeightE = new TextBox();
            button1 = new Button();
            button2 = new Button();
            OuError = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Pr0ErrorA = new Label();
            Pr0ErrorB = new Label();
            StartTraining = new Button();
            label2 = new Label();
            Errorthresh = new TextBox();
            label3 = new Label();
            learningRateInput = new TextBox();
            StopTraining = new Button();
            ExpectedLabel = new Label();
            ExpectedA0 = new TextBox();
            Errors = new Label();
            OutputError = new Label();
            SuspendLayout();
            // 
            // InNeuronA
            // 
            InNeuronA.Location = new Point(152, 49);
            InNeuronA.Name = "InNeuronA";
            InNeuronA.Size = new Size(125, 23);
            InNeuronA.TabIndex = 0;
            InNeuronA.Text = "0.35";
            InNeuronA.TextChanged += NeuronAChanged;
            // 
            // InNeuronB
            // 
            InNeuronB.Location = new Point(152, 153);
            InNeuronB.Name = "InNeuronB";
            InNeuronB.Size = new Size(125, 23);
            InNeuronB.TabIndex = 1;
            InNeuronB.Text = "0.9";
            InNeuronB.TextChanged += NeuronBChanged;
            // 
            // Pr0NeuronA
            // 
            Pr0NeuronA.Location = new Point(432, 48);
            Pr0NeuronA.Name = "Pr0NeuronA";
            Pr0NeuronA.ReadOnly = true;
            Pr0NeuronA.Size = new Size(125, 23);
            Pr0NeuronA.TabIndex = 3;
            // 
            // Pr0NeuronB
            // 
            Pr0NeuronB.Location = new Point(432, 156);
            Pr0NeuronB.Name = "Pr0NeuronB";
            Pr0NeuronB.ReadOnly = true;
            Pr0NeuronB.Size = new Size(125, 23);
            Pr0NeuronB.TabIndex = 4;
            // 
            // OuNeuronA
            // 
            OuNeuronA.Location = new Point(724, 97);
            OuNeuronA.Name = "OuNeuronA";
            OuNeuronA.ReadOnly = true;
            OuNeuronA.Size = new Size(125, 23);
            OuNeuronA.TabIndex = 5;
            // 
            // WeightA
            // 
            WeightA.Location = new Point(293, 22);
            WeightA.Name = "WeightA";
            WeightA.Size = new Size(125, 23);
            WeightA.TabIndex = 6;
            WeightA.Text = "0.1";
            WeightA.TextChanged += WeightA_TextChanged;
            // 
            // WeightB
            // 
            WeightB.Location = new Point(293, 77);
            WeightB.Name = "WeightB";
            WeightB.Size = new Size(125, 23);
            WeightB.TabIndex = 7;
            WeightB.Text = "0.4";
            WeightB.TextChanged += WeightB_TextChanged;
            // 
            // WeightD
            // 
            WeightD.Location = new Point(293, 190);
            WeightD.Name = "WeightD";
            WeightD.Size = new Size(125, 23);
            WeightD.TabIndex = 9;
            WeightD.Text = "0.6";
            WeightD.TextChanged += WeightD_TextChanged;
            // 
            // WeightC
            // 
            WeightC.Location = new Point(293, 130);
            WeightC.Name = "WeightC";
            WeightC.Size = new Size(125, 23);
            WeightC.TabIndex = 8;
            WeightC.Text = "0.8";
            WeightC.TextChanged += WeightC_TextChanged;
            // 
            // WeightF
            // 
            WeightF.Location = new Point(573, 156);
            WeightF.Name = "WeightF";
            WeightF.Size = new Size(125, 23);
            WeightF.TabIndex = 11;
            WeightF.Text = "0.9";
            WeightF.TextChanged += WeightF_TextChanged;
            // 
            // WeightE
            // 
            WeightE.Location = new Point(573, 47);
            WeightE.Name = "WeightE";
            WeightE.Size = new Size(125, 23);
            WeightE.TabIndex = 10;
            WeightE.Text = "0.3";
            WeightE.TextChanged += WeightE_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 12;
            button1.Text = "Randomize Weights";
            button1.UseVisualStyleBackColor = true;
            button1.Click += randomWeights;
            // 
            // button2
            // 
            button2.Location = new Point(12, 67);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 13;
            button2.Text = "FeedForward";
            button2.UseVisualStyleBackColor = true;
            button2.Click += FeedForward;
            // 
            // OuError
            // 
            OuError.AutoSize = true;
            OuError.Location = new Point(724, 127);
            OuError.Name = "OuError";
            OuError.Size = new Size(32, 15);
            OuError.TabIndex = 14;
            OuError.Text = "Error";
            // 
            // button3
            // 
            button3.Location = new Point(12, 39);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 15;
            button3.Text = "Randomize Inputs";
            button3.UseVisualStyleBackColor = true;
            button3.Click += randomizeInputs;
            // 
            // button4
            // 
            button4.Location = new Point(12, 94);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 22;
            button4.Text = "Update Weights";
            button4.UseVisualStyleBackColor = true;
            button4.Click += updateWeights;
            // 
            // button5
            // 
            button5.Location = new Point(12, 121);
            button5.Name = "button5";
            button5.Size = new Size(121, 23);
            button5.TabIndex = 23;
            button5.Text = "Train";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Train;
            // 
            // Pr0ErrorA
            // 
            Pr0ErrorA.AutoSize = true;
            Pr0ErrorA.Location = new Point(432, 74);
            Pr0ErrorA.Name = "Pr0ErrorA";
            Pr0ErrorA.Size = new Size(32, 15);
            Pr0ErrorA.TabIndex = 26;
            Pr0ErrorA.Text = "Error";
            // 
            // Pr0ErrorB
            // 
            Pr0ErrorB.AutoSize = true;
            Pr0ErrorB.Location = new Point(432, 182);
            Pr0ErrorB.Name = "Pr0ErrorB";
            Pr0ErrorB.Size = new Size(32, 15);
            Pr0ErrorB.TabIndex = 27;
            Pr0ErrorB.Text = "Error";
            // 
            // StartTraining
            // 
            StartTraining.Location = new Point(12, 293);
            StartTraining.Name = "StartTraining";
            StartTraining.Size = new Size(121, 23);
            StartTraining.TabIndex = 28;
            StartTraining.Text = "Run";
            StartTraining.UseVisualStyleBackColor = true;
            StartTraining.Click += StartTraining_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(822, 301);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 30;
            label2.Text = "Thresh";
            // 
            // Errorthresh
            // 
            Errorthresh.Location = new Point(817, 319);
            Errorthresh.Name = "Errorthresh";
            Errorthresh.Size = new Size(55, 23);
            Errorthresh.TabIndex = 29;
            Errorthresh.Text = ".001";
            Errorthresh.TextChanged += Errorthresh_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(736, 301);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 32;
            label3.Text = "LearningRate";
            // 
            // learningRateInput
            // 
            learningRateInput.Location = new Point(737, 319);
            learningRateInput.Name = "learningRateInput";
            learningRateInput.Size = new Size(74, 23);
            learningRateInput.TabIndex = 31;
            learningRateInput.Text = ".5";
            learningRateInput.TextChanged += learningRateInput_TextChanged;
            // 
            // StopTraining
            // 
            StopTraining.Location = new Point(12, 318);
            StopTraining.Name = "StopTraining";
            StopTraining.Size = new Size(121, 23);
            StopTraining.TabIndex = 33;
            StopTraining.Text = "Stop";
            StopTraining.UseVisualStyleBackColor = true;
            StopTraining.Click += StopTraining_Click;
            // 
            // ExpectedLabel
            // 
            ExpectedLabel.AutoSize = true;
            ExpectedLabel.Location = new Point(878, 301);
            ExpectedLabel.Name = "ExpectedLabel";
            ExpectedLabel.Size = new Size(55, 15);
            ExpectedLabel.TabIndex = 35;
            ExpectedLabel.Text = "Expected";
            // 
            // ExpectedA0
            // 
            ExpectedA0.Location = new Point(878, 319);
            ExpectedA0.Name = "ExpectedA0";
            ExpectedA0.Size = new Size(55, 23);
            ExpectedA0.TabIndex = 34;
            ExpectedA0.Text = ".001";
            ExpectedA0.TextChanged += ExpectedA_TextChanged;
            // 
            // Errors
            // 
            Errors.AutoSize = true;
            Errors.Location = new Point(420, 322);
            Errors.Name = "Errors";
            Errors.Size = new Size(32, 15);
            Errors.TabIndex = 36;
            Errors.Text = "Error";
            // 
            // OutputError
            // 
            OutputError.AutoSize = true;
            OutputError.Location = new Point(348, 322);
            OutputError.Name = "OutputError";
            OutputError.Size = new Size(73, 15);
            OutputError.TabIndex = 37;
            OutputError.Text = "OutputError:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 354);
            Controls.Add(OutputError);
            Controls.Add(Errors);
            Controls.Add(ExpectedLabel);
            Controls.Add(ExpectedA0);
            Controls.Add(StopTraining);
            Controls.Add(label3);
            Controls.Add(learningRateInput);
            Controls.Add(label2);
            Controls.Add(Errorthresh);
            Controls.Add(StartTraining);
            Controls.Add(Pr0ErrorB);
            Controls.Add(Pr0ErrorA);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(OuError);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(WeightF);
            Controls.Add(WeightE);
            Controls.Add(WeightD);
            Controls.Add(WeightC);
            Controls.Add(WeightB);
            Controls.Add(WeightA);
            Controls.Add(OuNeuronA);
            Controls.Add(Pr0NeuronB);
            Controls.Add(Pr0NeuronA);
            Controls.Add(InNeuronB);
            Controls.Add(InNeuronA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InNeuronA;
        private TextBox InNeuronB;
        private TextBox Pr0NeuronA;
        private TextBox Pr0NeuronB;
        private TextBox OuNeuronA;
        private TextBox WeightA;
        private TextBox WeightB;
        private TextBox WeightD;
        private TextBox WeightC;
        private TextBox WeightF;
        private TextBox WeightE;
        private Button button1;
        private Button button2;
        private Label OuError;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label Pr0ErrorA;
        private Label Pr0ErrorB;
        private Button StartTraining;
        private Label label2;
        private TextBox Errorthresh;
        private Label label3;
        private TextBox learningRateInput;
        private Button StopTraining;
        private Label ExpectedLabel;
        private TextBox ExpectedA0;
        private Label Errors;
        private Label OutputError;
    }
}