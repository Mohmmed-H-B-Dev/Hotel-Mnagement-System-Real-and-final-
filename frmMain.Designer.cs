namespace Hotel_Mnagement_System
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.manageReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingAccontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chanagPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.msMangerBasicControl = new System.Windows.Forms.MenuStrip();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcManger = new System.Windows.Forms.TabControl();
            this.msMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.msMangerBasicControl.SuspendLayout();
            this.tcManger.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageReservationsToolStripMenuItem,
            this.manageRoomsToolStripMenuItem,
            this.manageCustomersToolStripMenuItem,
            this.settingAccontToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1370, 72);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // manageReservationsToolStripMenuItem
            // 
            this.manageReservationsToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Manage_Reserva_appointment_64;
            this.manageReservationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageReservationsToolStripMenuItem.Name = "manageReservationsToolStripMenuItem";
            this.manageReservationsToolStripMenuItem.Size = new System.Drawing.Size(198, 68);
            this.manageReservationsToolStripMenuItem.Text = " Reservations";
            this.manageReservationsToolStripMenuItem.Click += new System.EventHandler(this.manageReservationsToolStripMenuItem_Click);
            // 
            // manageRoomsToolStripMenuItem
            // 
            this.manageRoomsToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Manage_Room_64;
            this.manageRoomsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            this.manageRoomsToolStripMenuItem.Size = new System.Drawing.Size(149, 68);
            this.manageRoomsToolStripMenuItem.Text = " Rooms";
            this.manageRoomsToolStripMenuItem.Click += new System.EventHandler(this.manageRoomsToolStripMenuItem_Click);
            // 
            // manageCustomersToolStripMenuItem
            // 
            this.manageCustomersToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Manage_customers_64;
            this.manageCustomersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            this.manageCustomersToolStripMenuItem.Size = new System.Drawing.Size(182, 68);
            this.manageCustomersToolStripMenuItem.Text = " Customers";
            this.manageCustomersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // settingAccontToolStripMenuItem
            // 
            this.settingAccontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myInformationToolStripMenuItem,
            this.chanagPasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.settingAccontToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.account_settings_64;
            this.settingAccontToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingAccontToolStripMenuItem.Name = "settingAccontToolStripMenuItem";
            this.settingAccontToolStripMenuItem.Size = new System.Drawing.Size(210, 68);
            this.settingAccontToolStripMenuItem.Text = "Setting Accont";
            // 
            // myInformationToolStripMenuItem
            // 
            this.myInformationToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.EmployeeDetails_32;
            this.myInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.myInformationToolStripMenuItem.Name = "myInformationToolStripMenuItem";
            this.myInformationToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.myInformationToolStripMenuItem.Text = "My Information";
            this.myInformationToolStripMenuItem.Click += new System.EventHandler(this.myInformationToolStripMenuItem_Click);
            // 
            // chanagPasswordToolStripMenuItem
            // 
            this.chanagPasswordToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Password_32;
            this.chanagPasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chanagPasswordToolStripMenuItem.Name = "chanagPasswordToolStripMenuItem";
            this.chanagPasswordToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.chanagPasswordToolStripMenuItem.Text = "Chanag Password";
            this.chanagPasswordToolStripMenuItem.Click += new System.EventHandler(this.chanagPasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.sign_out_32__2;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.logoutToolStripMenuItem.Text = "Sing Out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.msMangerBasicControl);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manger";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // msMangerBasicControl
            // 
            this.msMangerBasicControl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.msMangerBasicControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.manageUsersToolStripMenuItem1,
            this.reportsToolStripMenuItem});
            this.msMangerBasicControl.Location = new System.Drawing.Point(3, 3);
            this.msMangerBasicControl.Name = "msMangerBasicControl";
            this.msMangerBasicControl.Size = new System.Drawing.Size(666, 72);
            this.msMangerBasicControl.TabIndex = 1;
            this.msMangerBasicControl.Text = "menuStrip1";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Employees_64;
            this.manageEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(244, 68);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem1
            // 
            this.manageUsersToolStripMenuItem1.Image = global::Hotel_Mnagement_System.Properties.Resources.users_64;
            this.manageUsersToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageUsersToolStripMenuItem1.Name = "manageUsersToolStripMenuItem1";
            this.manageUsersToolStripMenuItem1.Size = new System.Drawing.Size(208, 68);
            this.manageUsersToolStripMenuItem1.Text = "Manage Users";
            this.manageUsersToolStripMenuItem1.Click += new System.EventHandler(this.manageUsersToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.general_reports_64;
            this.reportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(151, 68);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // tcManger
            // 
            this.tcManger.Controls.Add(this.tabPage1);
            this.tcManger.Font = new System.Drawing.Font("Tahoma", 18F);
            this.tcManger.Location = new System.Drawing.Point(12, 213);
            this.tcManger.Name = "tcManger";
            this.tcManger.SelectedIndex = 0;
            this.tcManger.Size = new System.Drawing.Size(680, 225);
            this.tcManger.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.tcManger);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.msMangerBasicControl.ResumeLayout(false);
            this.msMangerBasicControl.PerformLayout();
            this.tcManger.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem manageReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingAccontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chanagPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip msMangerBasicControl;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem1;
        private System.Windows.Forms.TabControl tcManger;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}