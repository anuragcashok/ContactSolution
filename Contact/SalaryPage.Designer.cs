namespace Contact
{
    partial class SalaryPage
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblNewSalary = new System.Windows.Forms.Label();
            this.lblEditSalary = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEditSal = new System.Windows.Forms.TextBox();
            this.txtEditJobTitle = new System.Windows.Forms.TextBox();
            this.lblEditSal = new System.Windows.Forms.Label();
            this.lblEditJobTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grdSalaries = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSalaries = new System.Windows.Forms.ComboBox();
            this.lstSalaries = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1146, 109);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Salary ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 122);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 31);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblNewSalary
            // 
            this.lblNewSalary.BackColor = System.Drawing.Color.Silver;
            this.lblNewSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSalary.Location = new System.Drawing.Point(12, 165);
            this.lblNewSalary.Name = "lblNewSalary";
            this.lblNewSalary.Size = new System.Drawing.Size(388, 31);
            this.lblNewSalary.TabIndex = 4;
            this.lblNewSalary.Text = "New Salary";
            this.lblNewSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEditSalary
            // 
            this.lblEditSalary.BackColor = System.Drawing.Color.Silver;
            this.lblEditSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSalary.Location = new System.Drawing.Point(438, 165);
            this.lblEditSalary.Name = "lblEditSalary";
            this.lblEditSalary.Size = new System.Drawing.Size(379, 31);
            this.lblEditSalary.TabIndex = 4;
            this.lblEditSalary.Text = "Edit Salary";
            this.lblEditSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(21, 255);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(96, 25);
            this.lblJobTitle.TabIndex = 5;
            this.lblJobTitle.Text = "Job Title";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(153, 252);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(247, 32);
            this.txtJobTitle.TabIndex = 6;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(21, 303);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(77, 25);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(153, 299);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(247, 32);
            this.txtSalary.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(134, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 31);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEditSal
            // 
            this.txtEditSal.Location = new System.Drawing.Point(576, 300);
            this.txtEditSal.Name = "txtEditSal";
            this.txtEditSal.Size = new System.Drawing.Size(247, 32);
            this.txtEditSal.TabIndex = 11;
            // 
            // txtEditJobTitle
            // 
            this.txtEditJobTitle.Location = new System.Drawing.Point(576, 253);
            this.txtEditJobTitle.Name = "txtEditJobTitle";
            this.txtEditJobTitle.Size = new System.Drawing.Size(247, 32);
            this.txtEditJobTitle.TabIndex = 12;
            // 
            // lblEditSal
            // 
            this.lblEditSal.AutoSize = true;
            this.lblEditSal.Location = new System.Drawing.Point(444, 304);
            this.lblEditSal.Name = "lblEditSal";
            this.lblEditSal.Size = new System.Drawing.Size(77, 25);
            this.lblEditSal.TabIndex = 9;
            this.lblEditSal.Text = "Salary";
            // 
            // lblEditJobTitle
            // 
            this.lblEditJobTitle.AutoSize = true;
            this.lblEditJobTitle.Location = new System.Drawing.Point(444, 256);
            this.lblEditJobTitle.Name = "lblEditJobTitle";
            this.lblEditJobTitle.Size = new System.Drawing.Size(96, 25);
            this.lblEditJobTitle.TabIndex = 10;
            this.lblEditJobTitle.Text = "Job Title";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(437, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdSalaries
            // 
            this.grdSalaries.AllowUserToAddRows = false;
            this.grdSalaries.AllowUserToDeleteRows = false;
            this.grdSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdSalaries.Location = new System.Drawing.Point(10, 403);
            this.grdSalaries.MultiSelect = false;
            this.grdSalaries.Name = "grdSalaries";
            this.grdSalaries.ReadOnly = true;
            this.grdSalaries.RowHeadersWidth = 51;
            this.grdSalaries.RowTemplate.Height = 24;
            this.grdSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSalaries.Size = new System.Drawing.Size(428, 208);
            this.grdSalaries.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(10, 630);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 31);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 630);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Salary";
            this.Column2.HeaderText = "Salary";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Display";
            this.Column3.HeaderText = "Display";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // cmbSalaries
            // 
            this.cmbSalaries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaries.FormattingEnabled = true;
            this.cmbSalaries.Location = new System.Drawing.Point(880, 260);
            this.cmbSalaries.Name = "cmbSalaries";
            this.cmbSalaries.Size = new System.Drawing.Size(224, 33);
            this.cmbSalaries.TabIndex = 14;
            // 
            // lstSalaries
            // 
            this.lstSalaries.FormattingEnabled = true;
            this.lstSalaries.ItemHeight = 25;
            this.lstSalaries.Location = new System.Drawing.Point(880, 325);
            this.lstSalaries.Name = "lstSalaries";
            this.lstSalaries.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSalaries.Size = new System.Drawing.Size(224, 154);
            this.lstSalaries.TabIndex = 15;
            // 
            // SalaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 703);
            this.Controls.Add(this.lstSalaries);
            this.Controls.Add(this.cmbSalaries);
            this.Controls.Add(this.grdSalaries);
            this.Controls.Add(this.txtEditSal);
            this.Controls.Add(this.txtEditJobTitle);
            this.Controls.Add(this.lblEditSal);
            this.Controls.Add(this.lblEditJobTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblEditSalary);
            this.Controls.Add(this.lblNewSalary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalaryPage";
            this.Text = "Salary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalaryPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblNewSalary;
        private System.Windows.Forms.Label lblEditSalary;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEditSal;
        private System.Windows.Forms.TextBox txtEditJobTitle;
        private System.Windows.Forms.Label lblEditSal;
        private System.Windows.Forms.Label lblEditJobTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdSalaries;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cmbSalaries;
        private System.Windows.Forms.ListBox lstSalaries;
    }
}