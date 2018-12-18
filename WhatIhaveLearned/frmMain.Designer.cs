namespace WhatIhaveLearned
{
    partial class frmMain
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
            this.btnCalculations = new System.Windows.Forms.Button();
            this.btnFunctions = new System.Windows.Forms.Button();
            this.btnLoops = new System.Windows.Forms.Button();
            this.btnConcatenation = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculations
            // 
            this.btnCalculations.Location = new System.Drawing.Point(76, 66);
            this.btnCalculations.Name = "btnCalculations";
            this.btnCalculations.Size = new System.Drawing.Size(84, 23);
            this.btnCalculations.TabIndex = 0;
            this.btnCalculations.Text = "Calculations";
            this.btnCalculations.UseVisualStyleBackColor = true;
            this.btnCalculations.Click += new System.EventHandler(this.btnCalculations_Click);
            // 
            // btnFunctions
            // 
            this.btnFunctions.Location = new System.Drawing.Point(76, 95);
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.Size = new System.Drawing.Size(84, 23);
            this.btnFunctions.TabIndex = 1;
            this.btnFunctions.Text = "Functions";
            this.btnFunctions.UseVisualStyleBackColor = true;
            this.btnFunctions.Click += new System.EventHandler(this.btnFunctions_Click);
            // 
            // btnLoops
            // 
            this.btnLoops.Location = new System.Drawing.Point(76, 125);
            this.btnLoops.Name = "btnLoops";
            this.btnLoops.Size = new System.Drawing.Size(84, 23);
            this.btnLoops.TabIndex = 2;
            this.btnLoops.Text = "Loops";
            this.btnLoops.UseVisualStyleBackColor = true;
            this.btnLoops.Click += new System.EventHandler(this.btnLoops_Click);
            // 
            // btnConcatenation
            // 
            this.btnConcatenation.Location = new System.Drawing.Point(76, 155);
            this.btnConcatenation.Name = "btnConcatenation";
            this.btnConcatenation.Size = new System.Drawing.Size(84, 23);
            this.btnConcatenation.TabIndex = 3;
            this.btnConcatenation.Text = "Concatenation";
            this.btnConcatenation.UseVisualStyleBackColor = true;
            this.btnConcatenation.Click += new System.EventHandler(this.btnConcatenation_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Location = new System.Drawing.Point(271, 66);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(75, 23);
            this.btnExitProgram.TabIndex = 4;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.btnConcatenation);
            this.Controls.Add(this.btnLoops);
            this.Controls.Add(this.btnFunctions);
            this.Controls.Add(this.btnCalculations);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculations;
        private System.Windows.Forms.Button btnFunctions;
        private System.Windows.Forms.Button btnLoops;
        private System.Windows.Forms.Button btnConcatenation;
        private System.Windows.Forms.Button btnExitProgram;
    }
}

