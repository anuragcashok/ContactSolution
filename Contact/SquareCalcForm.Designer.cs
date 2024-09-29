﻿namespace Contact
{
    partial class SquareCalcForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblSquare = new System.Windows.Forms.Label();
            this.txtSquare = new System.Windows.Forms.TextBox();
            this.btnFindSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(916, 80);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Square Calc";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(70, 165);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(92, 25);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(252, 161);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(219, 32);
            this.txtNumber.TabIndex = 1;
            // 
            // lblSquare
            // 
            this.lblSquare.AutoSize = true;
            this.lblSquare.Location = new System.Drawing.Point(70, 236);
            this.lblSquare.Name = "lblSquare";
            this.lblSquare.Size = new System.Drawing.Size(84, 25);
            this.lblSquare.TabIndex = 2;
            this.lblSquare.Text = "Square";
            // 
            // txtSquare
            // 
            this.txtSquare.Location = new System.Drawing.Point(252, 232);
            this.txtSquare.Name = "txtSquare";
            this.txtSquare.ReadOnly = true;
            this.txtSquare.Size = new System.Drawing.Size(219, 32);
            this.txtSquare.TabIndex = 3;
            // 
            // btnFindSquare
            // 
            this.btnFindSquare.Location = new System.Drawing.Point(252, 316);
            this.btnFindSquare.Name = "btnFindSquare";
            this.btnFindSquare.Size = new System.Drawing.Size(219, 55);
            this.btnFindSquare.TabIndex = 2;
            this.btnFindSquare.Text = "Find Square";
            this.btnFindSquare.UseVisualStyleBackColor = true;
            this.btnFindSquare.Click += new System.EventHandler(this.btnFindSquare_Click);
            // 
            // SquareCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 703);
            this.Controls.Add(this.btnFindSquare);
            this.Controls.Add(this.txtSquare);
            this.Controls.Add(this.lblSquare);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SquareCalcForm";
            this.Text = "Square Calc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SquareCalcForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblSquare;
        private System.Windows.Forms.TextBox txtSquare;
        private System.Windows.Forms.Button btnFindSquare;
    }
}