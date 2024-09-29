namespace Birds
{
    partial class CrowForm
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
            this.lblCrow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCrow
            // 
            this.lblCrow.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblCrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCrow.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrow.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCrow.Location = new System.Drawing.Point(0, 0);
            this.lblCrow.Name = "lblCrow";
            this.lblCrow.Size = new System.Drawing.Size(1348, 74);
            this.lblCrow.TabIndex = 1;
            this.lblCrow.Text = "Crow";
            this.lblCrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Birds.Properties.Resources.crow;
            this.pictureBox1.Location = new System.Drawing.Point(358, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 786);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCrow);
            this.Name = "CrowForm";
            this.Text = "CrowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCrow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}