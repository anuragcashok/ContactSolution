namespace Example2Project
{
    partial class frmEditor
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
            this.components = new System.ComponentModel.Container();
            this.lblEditorApp = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.dlgColour = new System.Windows.Forms.ColorDialog();
            this.staPage = new System.Windows.Forms.StatusStrip();
            this.staColour = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBacground = new System.Windows.Forms.Label();
            this.lblForeground = new System.Windows.Forms.Label();
            this.btnForeColour = new System.Windows.Forms.Button();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBlueBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGreenBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRedContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBlueContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGreenContext = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolLeft = new System.Windows.Forms.ToolStripButton();
            this.toolCenter = new System.Windows.Forms.ToolStripButton();
            this.toolRight = new System.Windows.Forms.ToolStripButton();
            this.pnlBottom.SuspendLayout();
            this.staPage.SuspendLayout();
            this.mnuBar.SuspendLayout();
            this.mnuEditor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEditorApp
            // 
            this.lblEditorApp.BackColor = System.Drawing.Color.LightCoral;
            this.lblEditorApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEditorApp.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorApp.Location = new System.Drawing.Point(0, 61);
            this.lblEditorApp.Name = "lblEditorApp";
            this.lblEditorApp.Size = new System.Drawing.Size(1255, 103);
            this.lblEditorApp.TabIndex = 0;
            this.lblEditorApp.Text = "Editor App";
            this.lblEditorApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblForeground);
            this.pnlBottom.Controls.Add(this.lblBacground);
            this.pnlBottom.Controls.Add(this.btnForeColour);
            this.pnlBottom.Controls.Add(this.btnMore);
            this.pnlBottom.Controls.Add(this.btnGreen);
            this.pnlBottom.Controls.Add(this.btnBlue);
            this.pnlBottom.Controls.Add(this.btnRed);
            this.pnlBottom.Controls.Add(this.staPage);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 512);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1255, 175);
            this.pnlBottom.TabIndex = 2;
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.mnuEditor;
            this.txtEditor.Location = new System.Drawing.Point(276, 181);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(721, 257);
            this.txtEditor.TabIndex = 3;
            this.txtEditor.Text = "I am Anurag,\r\nIntern at Quest Global.\r\n\r\n";
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.IndianRed;
            this.btnRed.Location = new System.Drawing.Point(26, 58);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(115, 38);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "&Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Turquoise;
            this.btnBlue.Location = new System.Drawing.Point(147, 58);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(115, 38);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.Text = "&Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGreen.Location = new System.Drawing.Point(287, 58);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(115, 38);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.Text = "&Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.Location = new System.Drawing.Point(424, 58);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(115, 38);
            this.btnMore.TabIndex = 0;
            this.btnMore.Text = "...";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // staPage
            // 
            this.staPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staColour});
            this.staPage.Location = new System.Drawing.Point(0, 149);
            this.staPage.Name = "staPage";
            this.staPage.Size = new System.Drawing.Size(1255, 26);
            this.staPage.TabIndex = 1;
            this.staPage.Text = "statusStrip1";
            // 
            // staColour
            // 
            this.staColour.Name = "staColour";
            this.staColour.Size = new System.Drawing.Size(80, 20);
            this.staColour.Text = "Indian Red";
            // 
            // lblBacground
            // 
            this.lblBacground.AutoSize = true;
            this.lblBacground.Location = new System.Drawing.Point(30, 14);
            this.lblBacground.Name = "lblBacground";
            this.lblBacground.Size = new System.Drawing.Size(131, 25);
            this.lblBacground.TabIndex = 2;
            this.lblBacground.Text = "Background";
            // 
            // lblForeground
            // 
            this.lblForeground.AutoSize = true;
            this.lblForeground.Location = new System.Drawing.Point(631, 14);
            this.lblForeground.Name = "lblForeground";
            this.lblForeground.Size = new System.Drawing.Size(128, 25);
            this.lblForeground.TabIndex = 2;
            this.lblForeground.Text = "Foreground";
            // 
            // btnForeColour
            // 
            this.btnForeColour.BackColor = System.Drawing.Color.Transparent;
            this.btnForeColour.Location = new System.Drawing.Point(636, 58);
            this.btnForeColour.Name = "btnForeColour";
            this.btnForeColour.Size = new System.Drawing.Size(154, 38);
            this.btnForeColour.TabIndex = 0;
            this.btnForeColour.Text = "Pick Colour";
            this.btnForeColour.UseVisualStyleBackColor = false;
            this.btnForeColour.Click += new System.EventHandler(this.btnForeColour_Click);
            // 
            // mnuBar
            // 
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(1255, 30);
            this.mnuBar.TabIndex = 5;
            this.mnuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripSeparator8,
            this.mnuSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedBg,
            this.toolStripSeparator1,
            this.mnuBlueBg,
            this.toolStripSeparator2,
            this.mnuGreenBg,
            this.toolStripSeparator3,
            this.mnuBg,
            this.toolStripSeparator4,
            this.mnuFg});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.colourToolStripMenuItem.Text = "&Colour";
            // 
            // mnuRedBg
            // 
            this.mnuRedBg.Name = "mnuRedBg";
            this.mnuRedBg.Size = new System.Drawing.Size(269, 26);
            this.mnuRedBg.Text = "&Red Background Colour";
            this.mnuRedBg.Click += new System.EventHandler(this.mnuRedBg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(266, 6);
            // 
            // mnuBlueBg
            // 
            this.mnuBlueBg.Name = "mnuBlueBg";
            this.mnuBlueBg.Size = new System.Drawing.Size(269, 26);
            this.mnuBlueBg.Text = "&Blue Background Colour";
            this.mnuBlueBg.Click += new System.EventHandler(this.mnuBlueBg_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(266, 6);
            // 
            // mnuGreenBg
            // 
            this.mnuGreenBg.Name = "mnuGreenBg";
            this.mnuGreenBg.Size = new System.Drawing.Size(269, 26);
            this.mnuGreenBg.Text = "&Green Background Colour";
            this.mnuGreenBg.Click += new System.EventHandler(this.mnuGreenBg_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(266, 6);
            // 
            // mnuBg
            // 
            this.mnuBg.Name = "mnuBg";
            this.mnuBg.Size = new System.Drawing.Size(269, 26);
            this.mnuBg.Text = "&Other Background Colour...";
            this.mnuBg.Click += new System.EventHandler(this.mnuBg_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(266, 6);
            // 
            // mnuFg
            // 
            this.mnuFg.Name = "mnuFg";
            this.mnuFg.Size = new System.Drawing.Size(269, 26);
            this.mnuFg.Text = "&Foreground Colour...";
            this.mnuFg.Click += new System.EventHandler(this.mnuFg_Click);
            // 
            // mnuEditor
            // 
            this.mnuEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedContext,
            this.toolStripSeparator5,
            this.mnuBlueContext,
            this.toolStripSeparator6,
            this.mnuGreenContext});
            this.mnuEditor.Name = "mnuEditor";
            this.mnuEditor.Size = new System.Drawing.Size(249, 88);
            // 
            // mnuRedContext
            // 
            this.mnuRedContext.Name = "mnuRedContext";
            this.mnuRedContext.Size = new System.Drawing.Size(248, 24);
            this.mnuRedContext.Text = "Red Background Colour";
            this.mnuRedContext.Click += new System.EventHandler(this.mnuRedContext_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(245, 6);
            // 
            // mnuBlueContext
            // 
            this.mnuBlueContext.Name = "mnuBlueContext";
            this.mnuBlueContext.Size = new System.Drawing.Size(248, 24);
            this.mnuBlueContext.Text = "Blue Background Colour";
            this.mnuBlueContext.Click += new System.EventHandler(this.mnuBlueContext_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(245, 6);
            // 
            // mnuGreenContext
            // 
            this.mnuGreenContext.Name = "mnuGreenContext";
            this.mnuGreenContext.Size = new System.Drawing.Size(248, 24);
            this.mnuGreenContext.Text = "Green Background Colour";
            this.mnuGreenContext.Click += new System.EventHandler(this.mnuGreenContext_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.toolStripSeparator7,
            this.mnuAlignLeft,
            this.mnuAlignCenter,
            this.mnuAlignRight});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(224, 26);
            this.mnuFont.Text = "Font....";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuAlignLeft
            // 
            this.mnuAlignLeft.Image = global::Example2Project.Properties.Resources._9111094_text_align_left_icon;
            this.mnuAlignLeft.Name = "mnuAlignLeft";
            this.mnuAlignLeft.Size = new System.Drawing.Size(224, 26);
            this.mnuAlignLeft.Text = "Align Left";
            this.mnuAlignLeft.Click += new System.EventHandler(this.mnuAlignLeft_Click);
            // 
            // mnuAlignCenter
            // 
            this.mnuAlignCenter.Image = global::Example2Project.Properties.Resources._9110909_text_align_center_icon;
            this.mnuAlignCenter.Name = "mnuAlignCenter";
            this.mnuAlignCenter.Size = new System.Drawing.Size(224, 26);
            this.mnuAlignCenter.Text = "Align Center";
            this.mnuAlignCenter.Click += new System.EventHandler(this.mnuAlignCenter_Click);
            // 
            // mnuAlignRight
            // 
            this.mnuAlignRight.Image = global::Example2Project.Properties.Resources._9110890_text_align_right_icon;
            this.mnuAlignRight.Name = "mnuAlignRight";
            this.mnuAlignRight.Size = new System.Drawing.Size(224, 26);
            this.mnuAlignRight.Text = "Align Right";
            this.mnuAlignRight.Click += new System.EventHandler(this.mnuAlignRight_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(224, 26);
            this.mnuOpen.Text = "&Open...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(224, 26);
            this.mnuSave.Text = "&Save...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "myText";
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "myText1.txt";
            this.dlgSave.Filter = "Text File (*.txt) | JSON File (*.json)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLeft,
            this.toolCenter,
            this.toolRight});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1255, 31);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolLeft
            // 
            this.toolLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLeft.Image = global::Example2Project.Properties.Resources._9111094_text_align_left_icon;
            this.toolLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLeft.Name = "toolLeft";
            this.toolLeft.Size = new System.Drawing.Size(29, 24);
            this.toolLeft.Text = "toolStripButton1";
            this.toolLeft.Click += new System.EventHandler(this.toolLeft_Click);
            // 
            // toolCenter
            // 
            this.toolCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCenter.Image = global::Example2Project.Properties.Resources._9110909_text_align_center_icon;
            this.toolCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCenter.Name = "toolCenter";
            this.toolCenter.Size = new System.Drawing.Size(29, 24);
            this.toolCenter.Text = "toolStripButton1";
            this.toolCenter.Click += new System.EventHandler(this.toolCenter_Click);
            // 
            // toolRight
            // 
            this.toolRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRight.Image = global::Example2Project.Properties.Resources._9110890_text_align_right_icon;
            this.toolRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRight.Name = "toolRight";
            this.toolRight.Size = new System.Drawing.Size(29, 24);
            this.toolRight.Text = "toolStripButton2";
            this.toolRight.Click += new System.EventHandler(this.toolRight_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 687);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.lblEditorApp);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuBar);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmEditor";
            this.Text = "Editor App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.staPage.ResumeLayout(false);
            this.staPage.PerformLayout();
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.mnuEditor.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditorApp;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.ColorDialog dlgColour;
        private System.Windows.Forms.StatusStrip staPage;
        private System.Windows.Forms.ToolStripStatusLabel staColour;
        private System.Windows.Forms.Label lblForeground;
        private System.Windows.Forms.Label lblBacground;
        private System.Windows.Forms.Button btnForeColour;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRedBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuBlueBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuGreenBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuFg;
        private System.Windows.Forms.ContextMenuStrip mnuEditor;
        private System.Windows.Forms.ToolStripMenuItem mnuRedContext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuBlueContext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuGreenContext;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolLeft;
        private System.Windows.Forms.ToolStripButton toolCenter;
        private System.Windows.Forms.ToolStripButton toolRight;
    }
}

