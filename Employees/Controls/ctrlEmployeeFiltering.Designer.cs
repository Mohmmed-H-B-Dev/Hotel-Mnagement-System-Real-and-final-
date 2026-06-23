namespace Hotel_Mnagement_System.Employees.Controls
{
    partial class ctrlEmployeeFiltering
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFilterEmployee = new System.Windows.Forms.GroupBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ctrlEmployeeInfo1 = new Hotel_Mnagement_System.Employees.Controls.ctrlEmployeeInfo();
            this.gbFilterEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilterEmployee
            // 
            this.gbFilterEmployee.Controls.Add(this.cmbFilterBy);
            this.gbFilterEmployee.Controls.Add(this.btnAddNewEmployee);
            this.gbFilterEmployee.Controls.Add(this.btnSearch);
            this.gbFilterEmployee.Controls.Add(this.label1);
            this.gbFilterEmployee.Controls.Add(this.txtFilter);
            this.gbFilterEmployee.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbFilterEmployee.Location = new System.Drawing.Point(3, 12);
            this.gbFilterEmployee.Name = "gbFilterEmployee";
            this.gbFilterEmployee.Size = new System.Drawing.Size(808, 68);
            this.gbFilterEmployee.TabIndex = 1;
            this.gbFilterEmployee.TabStop = false;
            this.gbFilterEmployee.Text = "Emplyee Filter";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "Employee ID",
            "ID Number"});
            this.cmbFilterBy.Location = new System.Drawing.Point(89, 27);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(203, 27);
            this.cmbFilterBy.TabIndex = 4;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By :";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(298, 26);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(311, 27);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Image = global::Hotel_Mnagement_System.Properties.Resources.Add_Employee_40;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(733, 17);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(61, 45);
            this.btnAddNewEmployee.TabIndex = 3;
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Hotel_Mnagement_System.Properties.Resources.SearchEmployee;
            this.btnSearch.Location = new System.Drawing.Point(662, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlEmployeeInfo1
            // 
            this.ctrlEmployeeInfo1.EmployeeID = -1;
            this.ctrlEmployeeInfo1.EmployeeInfo = null;
            this.ctrlEmployeeInfo1.Location = new System.Drawing.Point(3, 86);
            this.ctrlEmployeeInfo1.Name = "ctrlEmployeeInfo1";
            this.ctrlEmployeeInfo1.Size = new System.Drawing.Size(913, 294);
            this.ctrlEmployeeInfo1.TabIndex = 2;
            // 
            // ctrlEmployeeFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlEmployeeInfo1);
            this.Controls.Add(this.gbFilterEmployee);
            this.Name = "ctrlEmployeeFiltering";
            this.Size = new System.Drawing.Size(930, 371);
            this.Load += new System.EventHandler(this.ctrlEmployeeFiltering_Load);
            this.gbFilterEmployee.ResumeLayout(false);
            this.gbFilterEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

   //     private ctrlCustomerInfo ctrlEmployeeInfo1;
        private System.Windows.Forms.GroupBox gbFilterEmployee;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlEmployeeInfo ctrlEmployeeInfo1;
    }
}
