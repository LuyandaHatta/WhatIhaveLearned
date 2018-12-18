namespace WhatIhaveLearned
{
    partial class frmLoops
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
            this.rbReturn = new System.Windows.Forms.Button();
            this.rbForLoop = new System.Windows.Forms.RadioButton();
            this.rbWhileLoop = new System.Windows.Forms.RadioButton();
            this.rbDoWhileLoop = new System.Windows.Forms.RadioButton();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstLoop = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rbReturn
            // 
            this.rbReturn.Location = new System.Drawing.Point(31, 33);
            this.rbReturn.Name = "rbReturn";
            this.rbReturn.Size = new System.Drawing.Size(75, 23);
            this.rbReturn.TabIndex = 0;
            this.rbReturn.Text = "Return";
            this.rbReturn.UseVisualStyleBackColor = true;
            this.rbReturn.Click += new System.EventHandler(this.rbReturn_Click);
            // 
            // rbForLoop
            // 
            this.rbForLoop.AutoSize = true;
            this.rbForLoop.Location = new System.Drawing.Point(31, 103);
            this.rbForLoop.Name = "rbForLoop";
            this.rbForLoop.Size = new System.Drawing.Size(67, 17);
            this.rbForLoop.TabIndex = 1;
            this.rbForLoop.TabStop = true;
            this.rbForLoop.Text = "For Loop";
            this.rbForLoop.UseVisualStyleBackColor = true;
            // 
            // rbWhileLoop
            // 
            this.rbWhileLoop.AutoSize = true;
            this.rbWhileLoop.Location = new System.Drawing.Point(31, 145);
            this.rbWhileLoop.Name = "rbWhileLoop";
            this.rbWhileLoop.Size = new System.Drawing.Size(79, 17);
            this.rbWhileLoop.TabIndex = 2;
            this.rbWhileLoop.TabStop = true;
            this.rbWhileLoop.Text = "While Loop";
            this.rbWhileLoop.UseVisualStyleBackColor = true;
            // 
            // rbDoWhileLoop
            // 
            this.rbDoWhileLoop.AutoSize = true;
            this.rbDoWhileLoop.Location = new System.Drawing.Point(31, 187);
            this.rbDoWhileLoop.Name = "rbDoWhileLoop";
            this.rbDoWhileLoop.Size = new System.Drawing.Size(96, 17);
            this.rbDoWhileLoop.TabIndex = 3;
            this.rbDoWhileLoop.TabStop = true;
            this.rbDoWhileLoop.Text = "Do While Loop";
            this.rbDoWhileLoop.UseVisualStyleBackColor = true;
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(40, 305);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 4;
            this.btnLoop.Text = "Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(358, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstLoop
            // 
            this.lstLoop.FormattingEnabled = true;
            this.lstLoop.Location = new System.Drawing.Point(358, 67);
            this.lstLoop.Name = "lstLoop";
            this.lstLoop.Size = new System.Drawing.Size(165, 160);
            this.lstLoop.TabIndex = 6;
            this.lstLoop.SelectedIndexChanged += new System.EventHandler(this.lstLoop_SelectedIndexChanged);
            // 
            // frmLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLoop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.rbDoWhileLoop);
            this.Controls.Add(this.rbWhileLoop);
            this.Controls.Add(this.rbForLoop);
            this.Controls.Add(this.rbReturn);
            this.Name = "frmLoops";
            this.Text = "Loops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rbReturn;
        private System.Windows.Forms.RadioButton rbForLoop;
        private System.Windows.Forms.RadioButton rbWhileLoop;
        private System.Windows.Forms.RadioButton rbDoWhileLoop;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstLoop;
    }
}