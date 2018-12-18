namespace WhatIhaveLearned
{
    partial class frmFunctions
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.rbsABS = new System.Windows.Forms.RadioButton();
            this.rbSquareRoot = new System.Windows.Forms.RadioButton();
            this.rbStringLength = new System.Windows.Forms.RadioButton();
            this.rbStringCompare = new System.Windows.Forms.RadioButton();
            this.rbDateTime = new System.Windows.Forms.RadioButton();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(32, 28);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // rbsABS
            // 
            this.rbsABS.AutoSize = true;
            this.rbsABS.Location = new System.Drawing.Point(32, 80);
            this.rbsABS.Name = "rbsABS";
            this.rbsABS.Size = new System.Drawing.Size(46, 17);
            this.rbsABS.TabIndex = 1;
            this.rbsABS.TabStop = true;
            this.rbsABS.Text = "ABS";
            this.rbsABS.UseVisualStyleBackColor = true;
            // 
            // rbSquareRoot
            // 
            this.rbSquareRoot.AutoSize = true;
            this.rbSquareRoot.Location = new System.Drawing.Point(32, 118);
            this.rbSquareRoot.Name = "rbSquareRoot";
            this.rbSquareRoot.Size = new System.Drawing.Size(85, 17);
            this.rbSquareRoot.TabIndex = 2;
            this.rbSquareRoot.TabStop = true;
            this.rbSquareRoot.Text = "Square Root";
            this.rbSquareRoot.UseVisualStyleBackColor = true;
            // 
            // rbStringLength
            // 
            this.rbStringLength.AutoSize = true;
            this.rbStringLength.Location = new System.Drawing.Point(32, 157);
            this.rbStringLength.Name = "rbStringLength";
            this.rbStringLength.Size = new System.Drawing.Size(86, 17);
            this.rbStringLength.TabIndex = 3;
            this.rbStringLength.TabStop = true;
            this.rbStringLength.Text = "string Length";
            this.rbStringLength.UseVisualStyleBackColor = true;
            // 
            // rbStringCompare
            // 
            this.rbStringCompare.AutoSize = true;
            this.rbStringCompare.Location = new System.Drawing.Point(32, 197);
            this.rbStringCompare.Name = "rbStringCompare";
            this.rbStringCompare.Size = new System.Drawing.Size(97, 17);
            this.rbStringCompare.TabIndex = 4;
            this.rbStringCompare.TabStop = true;
            this.rbStringCompare.Text = "String Compare";
            this.rbStringCompare.UseVisualStyleBackColor = true;
            // 
            // rbDateTime
            // 
            this.rbDateTime.AutoSize = true;
            this.rbDateTime.Location = new System.Drawing.Point(32, 241);
            this.rbDateTime.Name = "rbDateTime";
            this.rbDateTime.Size = new System.Drawing.Size(74, 17);
            this.rbDateTime.TabIndex = 5;
            this.rbDateTime.TabStop = true;
            this.rbDateTime.Text = "Date Time";
            this.rbDateTime.UseVisualStyleBackColor = true;
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Location = new System.Drawing.Point(367, 82);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(43, 13);
            this.lblValue1.TabIndex = 6;
            this.lblValue1.Text = "Value 1";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(366, 120);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(43, 13);
            this.lblValue2.TabIndex = 7;
            this.lblValue2.Text = "Value 2";
            this.lblValue2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(370, 164);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Output";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(458, 82);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 20);
            this.txtValue1.TabIndex = 9;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(458, 115);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 20);
            this.txtValue2.TabIndex = 10;
            this.txtValue2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(458, 157);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(458, 241);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.rbDateTime);
            this.Controls.Add(this.rbStringCompare);
            this.Controls.Add(this.rbStringLength);
            this.Controls.Add(this.rbSquareRoot);
            this.Controls.Add(this.rbsABS);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmFunctions";
            this.Text = "Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton rbsABS;
        private System.Windows.Forms.RadioButton rbSquareRoot;
        private System.Windows.Forms.RadioButton rbStringLength;
        private System.Windows.Forms.RadioButton rbStringCompare;
        private System.Windows.Forms.RadioButton rbDateTime;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCalculate;
    }
}