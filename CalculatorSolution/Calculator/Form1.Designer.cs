namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttondivide = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelinfostart = new System.Windows.Forms.Label();
            this.buttonSelectCalc = new System.Windows.Forms.Button();
            this.groupBoxAdvanced = new System.Windows.Forms.GroupBox();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.labelResultAdvanced = new System.Windows.Forms.Label();
            this.textBoxAdvanced = new System.Windows.Forms.TextBox();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(56, 33);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(51, 20);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(53, 135);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(54, 13);
            this.LabelResult.TabIndex = 6;
            this.LabelResult.Text = "labelresult";
            this.LabelResult.Visible = false;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(56, 69);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(51, 20);
            this.textBoxB.TabIndex = 7;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(170, 34);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(42, 25);
            this.buttonPlus.TabIndex = 8;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(215, 264);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(170, 65);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(42, 24);
            this.buttonMinus.TabIndex = 10;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttondivide
            // 
            this.buttondivide.Location = new System.Drawing.Point(220, 35);
            this.buttondivide.Name = "buttondivide";
            this.buttondivide.Size = new System.Drawing.Size(42, 24);
            this.buttondivide.TabIndex = 12;
            this.buttondivide.Text = "/";
            this.buttondivide.UseVisualStyleBackColor = true;
            this.buttondivide.Click += new System.EventHandler(this.buttondivide_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(12, 264);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(75, 23);
            this.buttonHistory.TabIndex = 13;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(36, 36);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 13);
            this.labelA.TabIndex = 14;
            this.labelA.Text = "A:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(36, 72);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 13);
            this.labelB.TabIndex = 15;
            this.labelB.Text = "B:";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.textBoxA);
            this.groupBoxMain.Controls.Add(this.labelB);
            this.groupBoxMain.Controls.Add(this.LabelResult);
            this.groupBoxMain.Controls.Add(this.labelA);
            this.groupBoxMain.Controls.Add(this.textBoxB);
            this.groupBoxMain.Controls.Add(this.buttonPlus);
            this.groupBoxMain.Controls.Add(this.buttondivide);
            this.groupBoxMain.Controls.Add(this.buttonMinus);
            this.groupBoxMain.Controls.Add(this.button2);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 71);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(296, 166);
            this.groupBoxMain.TabIndex = 16;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Enter a value in A and B then choose operation";
            this.groupBoxMain.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Basic calculator",
            "Advanced calculator"});
            this.comboBox1.Location = new System.Drawing.Point(125, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelinfostart
            // 
            this.labelinfostart.AutoSize = true;
            this.labelinfostart.Location = new System.Drawing.Point(12, 9);
            this.labelinfostart.Name = "labelinfostart";
            this.labelinfostart.Size = new System.Drawing.Size(107, 13);
            this.labelinfostart.TabIndex = 18;
            this.labelinfostart.Text = "Select operation type";
            // 
            // buttonSelectCalc
            // 
            this.buttonSelectCalc.Location = new System.Drawing.Point(254, 7);
            this.buttonSelectCalc.Name = "buttonSelectCalc";
            this.buttonSelectCalc.Size = new System.Drawing.Size(54, 21);
            this.buttonSelectCalc.TabIndex = 19;
            this.buttonSelectCalc.Text = "select";
            this.buttonSelectCalc.UseVisualStyleBackColor = true;
            this.buttonSelectCalc.Click += new System.EventHandler(this.buttonSelectCalc_Click);
            // 
            // groupBoxAdvanced
            // 
            this.groupBoxAdvanced.Controls.Add(this.buttonPercent);
            this.groupBoxAdvanced.Controls.Add(this.buttonRoot);
            this.groupBoxAdvanced.Controls.Add(this.labelResultAdvanced);
            this.groupBoxAdvanced.Controls.Add(this.textBoxAdvanced);
            this.groupBoxAdvanced.Location = new System.Drawing.Point(12, 65);
            this.groupBoxAdvanced.Name = "groupBoxAdvanced";
            this.groupBoxAdvanced.Size = new System.Drawing.Size(296, 166);
            this.groupBoxAdvanced.TabIndex = 20;
            this.groupBoxAdvanced.TabStop = false;
            this.groupBoxAdvanced.Text = "Enter the value";
            this.groupBoxAdvanced.Visible = false;
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(187, 82);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(75, 23);
            this.buttonPercent.TabIndex = 3;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonRoot
            // 
            this.buttonRoot.Location = new System.Drawing.Point(187, 43);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(75, 23);
            this.buttonRoot.TabIndex = 2;
            this.buttonRoot.Text = "root";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.buttonRoot_Click_1);
            // 
            // labelResultAdvanced
            // 
            this.labelResultAdvanced.AutoSize = true;
            this.labelResultAdvanced.Location = new System.Drawing.Point(23, 92);
            this.labelResultAdvanced.Name = "labelResultAdvanced";
            this.labelResultAdvanced.Size = new System.Drawing.Size(108, 13);
            this.labelResultAdvanced.TabIndex = 1;
            this.labelResultAdvanced.Text = "labelResultAdvanced";
            this.labelResultAdvanced.Visible = false;
            // 
            // textBoxAdvanced
            // 
            this.textBoxAdvanced.Location = new System.Drawing.Point(26, 43);
            this.textBoxAdvanced.Name = "textBoxAdvanced";
            this.textBoxAdvanced.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdvanced.TabIndex = 0;
            this.textBoxAdvanced.TextChanged += new System.EventHandler(this.textBoxAdvanced_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 299);
            this.Controls.Add(this.groupBoxAdvanced);
            this.Controls.Add(this.buttonSelectCalc);
            this.Controls.Add(this.labelinfostart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxAdvanced.ResumeLayout(false);
            this.groupBoxAdvanced.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttondivide;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelinfostart;
        private System.Windows.Forms.Button buttonSelectCalc;
        private System.Windows.Forms.GroupBox groupBoxAdvanced;
        private System.Windows.Forms.Label labelResultAdvanced;
        private System.Windows.Forms.TextBox textBoxAdvanced;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonRoot;
    }
}

