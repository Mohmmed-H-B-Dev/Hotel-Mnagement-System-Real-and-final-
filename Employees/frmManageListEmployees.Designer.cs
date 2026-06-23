namespace Hotel_Mnagement_System.Employees
{
    partial class frmManageListEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManageEmployee = new System.Windows.Forms.DataGridView();
            this.cmsEmployees = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDetalis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnCloce = new System.Windows.Forms.Button();
            this.cmbFilterEmployees = new System.Windows.Forms.ComboBox();
            this.txtFilteringText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageEmployee)).BeginInit();
            this.cmsEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Mnagement_System.Properties.Resources.Manage_Employees;
            this.pictureBox1.Location = new System.Drawing.Point(419, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Epmloyees";
            // 
            // dgvManageEmployee
            // 
            this.dgvManageEmployee.AllowUserToAddRows = false;
            this.dgvManageEmployee.AllowUserToDeleteRows = false;
            this.dgvManageEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvManageEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageEmployee.ContextMenuStrip = this.cmsEmployees;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageEmployee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageEmployee.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvManageEmployee.Location = new System.Drawing.Point(12, 269);
            this.dgvManageEmployee.Name = "dgvManageEmployee";
            this.dgvManageEmployee.ReadOnly = true;
            this.dgvManageEmployee.Size = new System.Drawing.Size(1321, 240);
            this.dgvManageEmployee.TabIndex = 2;
            // 
            // cmsEmployees
            // 
            this.cmsEmployees.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetalis,
            this.toolStripSeparator1,
            this.tsmiAddNewEmployee,
            this.toolStripSeparator2,
            this.tsmiEditEmployee,
            this.toolStripSeparator3,
            this.tmsiDeleteEmployee});
            this.cmsEmployees.Name = "cmsEmployees";
            this.cmsEmployees.Size = new System.Drawing.Size(233, 174);
            this.cmsEmployees.Text = "Employees";
            // 
            // tsmiShowDetalis
            // 
            this.tsmiShowDetalis.Image = global::Hotel_Mnagement_System.Properties.Resources.Employee_Info_32;
            this.tsmiShowDetalis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowDetalis.Name = "tsmiShowDetalis";
            this.tsmiShowDetalis.Size = new System.Drawing.Size(232, 38);
            this.tsmiShowDetalis.Text = "Show Detalis";
            this.tsmiShowDetalis.Click += new System.EventHandler(this.tsmiShowDetalis_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiAddNewEmployee
            // 
            this.tsmiAddNewEmployee.Image = global::Hotel_Mnagement_System.Properties.Resources.AddEmployee_32;
            this.tsmiAddNewEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddNewEmployee.Name = "tsmiAddNewEmployee";
            this.tsmiAddNewEmployee.Size = new System.Drawing.Size(232, 38);
            this.tsmiAddNewEmployee.Text = "Add New Employee";
            this.tsmiAddNewEmployee.Click += new System.EventHandler(this.tsmiAddNewEmployee_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiEditEmployee
            // 
            this.tsmiEditEmployee.Image = global::Hotel_Mnagement_System.Properties.Resources.Employee_update_32;
            this.tsmiEditEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEditEmployee.Name = "tsmiEditEmployee";
            this.tsmiEditEmployee.Size = new System.Drawing.Size(232, 38);
            this.tsmiEditEmployee.Text = "Edit Employee";
            this.tsmiEditEmployee.Click += new System.EventHandler(this.tsmiEditEmployee_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // tmsiDeleteEmployee
            // 
            this.tmsiDeleteEmployee.Image = global::Hotel_Mnagement_System.Properties.Resources.Employee_delete_32;
            this.tmsiDeleteEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsiDeleteEmployee.Name = "tmsiDeleteEmployee";
            this.tmsiDeleteEmployee.Size = new System.Drawing.Size(232, 38);
            this.tmsiDeleteEmployee.Text = "Delete Employee";
            this.tmsiDeleteEmployee.Click += new System.EventHandler(this.tmsiDeleteEmployee_Click);
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewEmployee.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAddNewEmployee.Image = global::Hotel_Mnagement_System.Properties.Resources.AddEmployee_32;
            this.btnAddNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(1169, 228);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(164, 35);
            this.btnAddNewEmployee.TabIndex = 3;
            this.btnAddNewEmployee.Text = "New Employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(12, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count Record:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblRecordCount.Location = new System.Drawing.Point(154, 523);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(51, 23);
            this.lblRecordCount.TabIndex = 5;
            this.lblRecordCount.Text = "[???]";
            // 
            // btnCloce
            // 
            this.btnCloce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloce.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCloce.Image = global::Hotel_Mnagement_System.Properties.Resources.Close_32;
            this.btnCloce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloce.Location = new System.Drawing.Point(1169, 520);
            this.btnCloce.Name = "btnCloce";
            this.btnCloce.Size = new System.Drawing.Size(164, 35);
            this.btnCloce.TabIndex = 6;
            this.btnCloce.Text = "Close ";
            this.btnCloce.UseVisualStyleBackColor = true;
            this.btnCloce.Click += new System.EventHandler(this.btnCloce_Click);
            // 
            // cmbFilterEmployees
            // 
            this.cmbFilterEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterEmployees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFilterEmployees.FormattingEnabled = true;
            this.cmbFilterEmployees.Items.AddRange(new object[] {
            "None",
            "Employee ID",
            "ID Number",
            "Full Name",
            "Gendor",
            "Country Name"});
            this.cmbFilterEmployees.Location = new System.Drawing.Point(118, 236);
            this.cmbFilterEmployees.Name = "cmbFilterEmployees";
            this.cmbFilterEmployees.Size = new System.Drawing.Size(195, 27);
            this.cmbFilterEmployees.TabIndex = 7;
            this.cmbFilterEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbFilterEmployees_SelectedIndexChanged);
            // 
            // txtFilteringText
            // 
            this.txtFilteringText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFilteringText.Location = new System.Drawing.Point(319, 237);
            this.txtFilteringText.Name = "txtFilteringText";
            this.txtFilteringText.Size = new System.Drawing.Size(296, 27);
            this.txtFilteringText.TabIndex = 8;
            this.txtFilteringText.Visible = false;
            this.txtFilteringText.TextChanged += new System.EventHandler(this.txtFilteringText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(16, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter By :";
            // 
            // frmManageListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilteringText);
            this.Controls.Add(this.cmbFilterEmployees);
            this.Controls.Add(this.btnCloce);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewEmployee);
            this.Controls.Add(this.dgvManageEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageListEmployees";
            this.Text = "frmManageListEmployees";
            this.Load += new System.EventHandler(this.frmManageListEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageEmployee)).EndInit();
            this.cmsEmployees.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManageEmployee;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnCloce;
        private System.Windows.Forms.ComboBox cmbFilterEmployees;
        private System.Windows.Forms.TextBox txtFilteringText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsEmployees;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetalis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditEmployee;
        private System.Windows.Forms.ToolStripMenuItem tmsiDeleteEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}