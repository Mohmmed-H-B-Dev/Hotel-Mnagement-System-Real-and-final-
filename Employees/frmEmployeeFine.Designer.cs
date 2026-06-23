namespace Hotel_Mnagement_System.Employees
{
    partial class frmEmployeeFine
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
            this.ctrlEmployeeFiltering1 = new Hotel_Mnagement_System.Employees.Controls.ctrlEmployeeFiltering();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlEmployeeFiltering1
            // 
            this.ctrlEmployeeFiltering1.EmployeeFilter = true;
            this.ctrlEmployeeFiltering1.EmployeeID = -1;
            this.ctrlEmployeeFiltering1.Location = new System.Drawing.Point(18, 72);
            this.ctrlEmployeeFiltering1.Name = "ctrlEmployeeFiltering1";
            this.ctrlEmployeeFiltering1.Size = new System.Drawing.Size(930, 395);
            this.ctrlEmployeeFiltering1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(317, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 42);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = " Employee Find";
            // 
            // frmEmployeeFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 478);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlEmployeeFiltering1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeFine";
            this.Text = "Employee Fine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlEmployeeFiltering ctrlEmployeeFiltering1;
        private System.Windows.Forms.Label lblTitle;
    }
}