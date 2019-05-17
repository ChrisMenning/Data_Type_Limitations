namespace DoubleVsDecimal
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
            this.labelInt = new System.Windows.Forms.Label();
            this.labelDecimal = new System.Windows.Forms.Label();
            this.labelDouble = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxOutInt = new System.Windows.Forms.TextBox();
            this.textBoxOutDecimal = new System.Windows.Forms.TextBox();
            this.textBoxOutDouble = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDecRange = new System.Windows.Forms.Label();
            this.labelIntRange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Location = new System.Drawing.Point(15, 134);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(23, 17);
            this.labelInt.TabIndex = 0;
            this.labelInt.Text = "Int";
            // 
            // labelDecimal
            // 
            this.labelDecimal.AutoSize = true;
            this.labelDecimal.Location = new System.Drawing.Point(15, 187);
            this.labelDecimal.Name = "labelDecimal";
            this.labelDecimal.Size = new System.Drawing.Size(58, 17);
            this.labelDecimal.TabIndex = 1;
            this.labelDecimal.Text = "Decimal";
            // 
            // labelDouble
            // 
            this.labelDouble.AutoSize = true;
            this.labelDouble.Location = new System.Drawing.Point(15, 161);
            this.labelDouble.Name = "labelDouble";
            this.labelDouble.Size = new System.Drawing.Size(53, 17);
            this.labelDouble.TabIndex = 2;
            this.labelDouble.Text = "Double";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(132, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(685, 22);
            this.textBoxInput.TabIndex = 3;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(13, 12);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(105, 17);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Input a Number";
            // 
            // textBoxOutInt
            // 
            this.textBoxOutInt.Location = new System.Drawing.Point(488, 131);
            this.textBoxOutInt.Name = "textBoxOutInt";
            this.textBoxOutInt.Size = new System.Drawing.Size(331, 22);
            this.textBoxOutInt.TabIndex = 5;
            // 
            // textBoxOutDecimal
            // 
            this.textBoxOutDecimal.Location = new System.Drawing.Point(488, 184);
            this.textBoxOutDecimal.Name = "textBoxOutDecimal";
            this.textBoxOutDecimal.Size = new System.Drawing.Size(331, 22);
            this.textBoxOutDecimal.TabIndex = 6;
            // 
            // textBoxOutDouble
            // 
            this.textBoxOutDouble.Location = new System.Drawing.Point(488, 158);
            this.textBoxOutDouble.Name = "textBoxOutDouble";
            this.textBoxOutDouble.Size = new System.Drawing.Size(331, 22);
            this.textBoxOutDouble.TabIndex = 7;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(16, 49);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(801, 35);
            this.buttonConvert.TabIndex = 8;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Type      |     Range                                            |    Precis" +
    "ion       |        Converted Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "± 5.0 x 10^324 to ± 1.7 x 10^308";
            // 
            // labelDecRange
            // 
            this.labelDecRange.AutoSize = true;
            this.labelDecRange.Location = new System.Drawing.Point(122, 187);
            this.labelDecRange.Name = "labelDecRange";
            this.labelDecRange.Size = new System.Drawing.Size(222, 17);
            this.labelDecRange.TabIndex = 11;
            this.labelDecRange.Text = "± 1.0 x 10^28 to ± 7.9228 x 10^28";
            // 
            // labelIntRange
            // 
            this.labelIntRange.AutoSize = true;
            this.labelIntRange.Location = new System.Drawing.Point(122, 134);
            this.labelIntRange.Name = "labelIntRange";
            this.labelIntRange.Size = new System.Drawing.Size(101, 17);
            this.labelIntRange.TabIndex = 10;
            this.labelIntRange.Text = "± 2.147 x 10^9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "~15-17 digits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "28 digits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "100%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDecRange);
            this.Controls.Add(this.labelIntRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxOutDouble);
            this.Controls.Add(this.textBoxOutDecimal);
            this.Controls.Add(this.textBoxOutInt);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelDouble);
            this.Controls.Add(this.labelDecimal);
            this.Controls.Add(this.labelInt);
            this.Name = "Form1";
            this.Text = "Data Type Limitations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelDecimal;
        private System.Windows.Forms.Label labelDouble;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxOutInt;
        private System.Windows.Forms.TextBox textBoxOutDecimal;
        private System.Windows.Forms.TextBox textBoxOutDouble;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDecRange;
        private System.Windows.Forms.Label labelIntRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

