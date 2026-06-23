namespace Hotel_Mnagement_System.Users
{
    partial class frmAddEditUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEmployeeInfo = new System.Windows.Forms.TabPage();
            this.ctrlEmployeeFiltering1 = new Hotel_Mnagement_System.Employees.Controls.ctrlEmployeeFiltering();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpAddUserInfo = new System.Windows.Forms.TabPage();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.chbHidePassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpEmployeeInfo.SuspendLayout();
            this.tpAddUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add New User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Mnagement_System.Properties.Resources.Add_New_User_72;
            this.pictureBox1.Location = new System.Drawing.Point(456, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEmployeeInfo);
            this.tabControl1.Controls.Add(this.tpAddUserInfo);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 458);
            this.tabControl1.TabIndex = 4;
            // 
            // tpEmployeeInfo
            // 
            this.tpEmployeeInfo.Controls.Add(this.ctrlEmployeeFiltering1);
            this.tpEmployeeInfo.Controls.Add(this.btnNext);
            this.tpEmployeeInfo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tpEmployeeInfo.Location = new System.Drawing.Point(4, 28);
            this.tpEmployeeInfo.Name = "tpEmployeeInfo";
            this.tpEmployeeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeInfo.Size = new System.Drawing.Size(948, 426);
            this.tpEmployeeInfo.TabIndex = 0;
            this.tpEmployeeInfo.Text = "Employee Info";
            this.tpEmployeeInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlEmployeeFiltering1
            // 
            this.ctrlEmployeeFiltering1.EmployeeFilter = true;
            this.ctrlEmployeeFiltering1.EmployeeID = -1;
            this.ctrlEmployeeFiltering1.Location = new System.Drawing.Point(6, 6);
            this.ctrlEmployeeFiltering1.Name = "ctrlEmployeeFiltering1";
            this.ctrlEmployeeFiltering1.Size = new System.Drawing.Size(930, 366);
            this.ctrlEmployeeFiltering1.TabIndex = 4;
            this.ctrlEmployeeFiltering1.OnSelectedEmployee += new System.Action<int>(this.ctrlEmployeeFiltering1_OnSelectedEmployee);
            this.ctrlEmployeeFiltering1.Load += new System.EventHandler(this.ctrlEmployeeFiltering1_Load);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNext.Image = global::Hotel_Mnagement_System.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(6, 371);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 49);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpAddUserInfo
            // 
            this.tpAddUserInfo.Controls.Add(this.txtConfirmPassword);
            this.tpAddUserInfo.Controls.Add(this.pictureBox6);
            this.tpAddUserInfo.Controls.Add(this.label5);
            this.tpAddUserInfo.Controls.Add(this.lblEmployeeID);
            this.tpAddUserInfo.Controls.Add(this.pictureBox5);
            this.tpAddUserInfo.Controls.Add(this.label6);
            this.tpAddUserInfo.Controls.Add(this.chbIsActive);
            this.tpAddUserInfo.Controls.Add(this.chbHidePassword);
            this.tpAddUserInfo.Controls.Add(this.txtPassword);
            this.tpAddUserInfo.Controls.Add(this.txtUserName);
            this.tpAddUserInfo.Controls.Add(this.lblUserID);
            this.tpAddUserInfo.Controls.Add(this.pictureBox4);
            this.tpAddUserInfo.Controls.Add(this.label4);
            this.tpAddUserInfo.Controls.Add(this.pictureBox3);
            this.tpAddUserInfo.Controls.Add(this.label3);
            this.tpAddUserInfo.Controls.Add(this.pictureBox2);
            this.tpAddUserInfo.Controls.Add(this.label2);
            this.tpAddUserInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tpAddUserInfo.Location = new System.Drawing.Point(4, 28);
            this.tpAddUserInfo.Name = "tpAddUserInfo";
            this.tpAddUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddUserInfo.Size = new System.Drawing.Size(948, 426);
            this.tpAddUserInfo.TabIndex = 1;
            this.tpAddUserInfo.Text = "Add User Info";
            this.tpAddUserInfo.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(229, 242);
            this.txtConfirmPassword.MaxLength = 30;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(179, 27);
            this.txtConfirmPassword.TabIndex = 20;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Hotel_Mnagement_System.Properties.Resources.Password_32;
            this.pictureBox6.Location = new System.Drawing.Point(183, 238);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Confirm  Password :";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(225, 98);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(45, 19);
            this.lblEmployeeID.TabIndex = 17;
            this.lblEmployeeID.Text = "[???]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Hotel_Mnagement_System.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(183, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Employee ID:";
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Font = new System.Drawing.Font("Tahoma", 14F);
            this.chbIsActive.Location = new System.Drawing.Point(229, 298);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(99, 27);
            this.chbIsActive.TabIndex = 14;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // chbHidePassword
            // 
            this.chbHidePassword.AutoSize = true;
            this.chbHidePassword.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chbHidePassword.Location = new System.Drawing.Point(424, 203);
            this.chbHidePassword.Name = "chbHidePassword";
            this.chbHidePassword.Size = new System.Drawing.Size(96, 17);
            this.chbHidePassword.TabIndex = 13;
            this.chbHidePassword.Text = "Hide Password";
            this.chbHidePassword.UseVisualStyleBackColor = true;
            this.chbHidePassword.CheckedChanged += new System.EventHandler(this.chbHidePassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(229, 196);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 27);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(229, 151);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(179, 27);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(225, 52);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(45, 19);
            this.lblUserID.TabIndex = 10;
            this.lblUserID.Text = "[???]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hotel_Mnagement_System.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(183, 52);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "User ID :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hotel_Mnagement_System.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(183, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel_Mnagement_System.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(183, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Image = global::Hotel_Mnagement_System.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(877, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 49);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::Hotel_Mnagement_System.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(787, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditUser";
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpEmployeeInfo.ResumeLayout(false);
            this.tpAddUserInfo.ResumeLayout(false);
            this.tpAddUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEmployeeInfo;
        private System.Windows.Forms.TabPage tpAddUserInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.CheckBox chbHidePassword;
        private Employees.Controls.ctrlEmployeeFiltering ctrlEmployeeFiltering1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
    }
}