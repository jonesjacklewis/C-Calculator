namespace WindowsFormsApplication1
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
            this.LblResult = new System.Windows.Forms.Label();
            this.LblDescResult = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.LblDescH1 = new System.Windows.Forms.Label();
            this.Lblnum1 = new System.Windows.Forms.Label();
            this.Lblnum2 = new System.Windows.Forms.Label();
            this.LblDescFunc = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(206, 59);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(37, 13);
            this.LblResult.TabIndex = 0;
            this.LblResult.Text = "Result";
            // 
            // LblDescResult
            // 
            this.LblDescResult.AutoSize = true;
            this.LblDescResult.Location = new System.Drawing.Point(93, 59);
            this.LblDescResult.Name = "LblDescResult";
            this.LblDescResult.Size = new System.Drawing.Size(37, 13);
            this.LblDescResult.TabIndex = 1;
            this.LblDescResult.Text = "Result";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(30, 164);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(316, 164);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // LblDescH1
            // 
            this.LblDescH1.AutoSize = true;
            this.LblDescH1.Location = new System.Drawing.Point(313, 411);
            this.LblDescH1.Name = "LblDescH1";
            this.LblDescH1.Size = new System.Drawing.Size(131, 39);
            this.LblDescH1.TabIndex = 4;
            this.LblDescH1.Text = "For sqrt, trig functions, \r\nlogarithms factorial,\r\nand abs only fill in one box\r\n" +
    "";
            // 
            // Lblnum1
            // 
            this.Lblnum1.AutoSize = true;
            this.Lblnum1.Location = new System.Drawing.Point(70, 148);
            this.Lblnum1.Name = "Lblnum1";
            this.Lblnum1.Size = new System.Drawing.Size(33, 13);
            this.Lblnum1.TabIndex = 5;
            this.Lblnum1.Text = "num1";
            // 
            // Lblnum2
            // 
            this.Lblnum2.AutoSize = true;
            this.Lblnum2.Location = new System.Drawing.Point(344, 148);
            this.Lblnum2.Name = "Lblnum2";
            this.Lblnum2.Size = new System.Drawing.Size(33, 13);
            this.Lblnum2.TabIndex = 6;
            this.Lblnum2.Text = "num2";
            // 
            // LblDescFunc
            // 
            this.LblDescFunc.AutoSize = true;
            this.LblDescFunc.Location = new System.Drawing.Point(206, 114);
            this.LblDescFunc.Name = "LblDescFunc";
            this.LblDescFunc.Size = new System.Drawing.Size(48, 13);
            this.LblDescFunc.TabIndex = 7;
            this.LblDescFunc.Text = "Function";
            // 
            // cmbFunction
            // 
            this.cmbFunction.FormattingEnabled = true;
            this.cmbFunction.Items.AddRange(new object[] {
            "num1+num2",
            "num1-num2",
            "num1*num2",
            "num1÷num2",
            "num1 Mod num2",
            "Power Of (num1^num2)",
            "√(num)",
            "Sin(num)",
            "Cos(num)",
            "Tan(num)",
            "Log10(num)",
            "ln(num)",
            "num! (Factorial)",
            "Abs(num)",
            "Random"});
            this.cmbFunction.Location = new System.Drawing.Point(175, 163);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(121, 21);
            this.cmbFunction.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(189, 301);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(73, 348);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Store Latest Result";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 477);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cmbFunction);
            this.Controls.Add(this.LblDescFunc);
            this.Controls.Add(this.Lblnum2);
            this.Controls.Add(this.Lblnum1);
            this.Controls.Add(this.LblDescH1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.LblDescResult);
            this.Controls.Add(this.LblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblDescResult;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label LblDescH1;
        private System.Windows.Forms.Label Lblnum1;
        private System.Windows.Forms.Label Lblnum2;
        private System.Windows.Forms.Label LblDescFunc;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button BtnSave;
    }
}

