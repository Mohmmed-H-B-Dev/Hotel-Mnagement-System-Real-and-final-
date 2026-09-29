namespace Hotel_Mnagement_System.Reservations
{
    partial class frmManageListReservations
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmsiDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowDetalis = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReservations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilteringText = new System.Windows.Forms.TextBox();
            this.cmbFilterReservation = new System.Windows.Forms.ComboBox();
            this.btnCloce = new System.Windows.Forms.Button();
            this.dgvManageReservation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblWithGroup = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDataFrom = new System.Windows.Forms.Label();
            this.lblVisitNumber = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRoomInfo = new System.Windows.Forms.GroupBox();
            this.lblFeesForMonth = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblTypeRoom = new System.Windows.Forms.Label();
            this.lblFeesForDay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAddNewReservation = new System.Windows.Forms.Button();
            this.btnExpireBookingForTomorrow = new System.Windows.Forms.Button();
            this.Guna2npExpireBookingForTomorrow = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.gbExpireBooking = new System.Windows.Forms.GroupBox();
            this.btnExpiredBooking = new System.Windows.Forms.Button();
            this.guna2npExpiredBooking = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnRenewReservation = new System.Windows.Forms.Button();
            this.cmsReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCustomerInfo.SuspendLayout();
            this.gbRoomInfo.SuspendLayout();
            this.gbExpireBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(16, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Filter By :";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblRecordCount.Location = new System.Drawing.Point(154, 511);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(51, 23);
            this.lblRecordCount.TabIndex = 15;
            this.lblRecordCount.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(12, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Count Record:";
            // 
            // tmsiDeleteEmployee
            // 
            this.tmsiDeleteEmployee.Image = global::Hotel_Mnagement_System.Properties.Resources.Employee_delete_32;
            this.tmsiDeleteEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsiDeleteEmployee.Name = "tmsiDeleteEmployee";
            this.tmsiDeleteEmployee.Size = new System.Drawing.Size(232, 38);
            this.tmsiDeleteEmployee.Text = "Delete Employee";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiEditReservations
            // 
            this.tsmiEditReservations.Image = global::Hotel_Mnagement_System.Properties.Resources.Employee_update_32;
            this.tsmiEditReservations.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEditReservations.Name = "tsmiEditReservations";
            this.tsmiEditReservations.Size = new System.Drawing.Size(232, 38);
            this.tsmiEditReservations.Text = "Edit Reservation";
            this.tsmiEditReservations.Click += new System.EventHandler(this.tsmiEditReservations_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiAddNewEmployee
            // 
            this.tsmiAddNewEmployee.Image = global::Hotel_Mnagement_System.Properties.Resources.AddEmployee_32;
            this.tsmiAddNewEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddNewEmployee.Name = "tsmiAddNewEmployee";
            this.tsmiAddNewEmployee.Size = new System.Drawing.Size(232, 38);
            this.tsmiAddNewEmployee.Text = "Add New Employee";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiShowDetalis
            // 
            this.tsmiShowDetalis.Image = global::Hotel_Mnagement_System.Properties.Resources.Employee_Info_32;
            this.tsmiShowDetalis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowDetalis.Name = "tsmiShowDetalis";
            this.tsmiShowDetalis.Size = new System.Drawing.Size(232, 38);
            this.tsmiShowDetalis.Text = "Show Detalis";
            // 
            // cmsReservations
            // 
            this.cmsReservations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsReservations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetalis,
            this.toolStripSeparator1,
            this.tsmiAddNewEmployee,
            this.toolStripSeparator2,
            this.tsmiEditReservations,
            this.toolStripSeparator3,
            this.tmsiDeleteEmployee,
            this.sendEmailToolStripMenuItem});
            this.cmsReservations.Name = "cmsEmployees";
            this.cmsReservations.Size = new System.Drawing.Size(233, 212);
            this.cmsReservations.Text = "Reservations";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // txtFilteringText
            // 
            this.txtFilteringText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFilteringText.Location = new System.Drawing.Point(319, 225);
            this.txtFilteringText.Name = "txtFilteringText";
            this.txtFilteringText.Size = new System.Drawing.Size(253, 27);
            this.txtFilteringText.TabIndex = 18;
            this.txtFilteringText.Visible = false;
            // 
            // cmbFilterReservation
            // 
            this.cmbFilterReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterReservation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFilterReservation.FormattingEnabled = true;
            this.cmbFilterReservation.Items.AddRange(new object[] {
            "None",
            "Reservation ID",
            "Room ID",
            "ID Numbe",
            "Contact Number"});
            this.cmbFilterReservation.Location = new System.Drawing.Point(118, 224);
            this.cmbFilterReservation.Name = "cmbFilterReservation";
            this.cmbFilterReservation.Size = new System.Drawing.Size(195, 27);
            this.cmbFilterReservation.TabIndex = 17;
            // 
            // btnCloce
            // 
            this.btnCloce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloce.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCloce.Image = global::Hotel_Mnagement_System.Properties.Resources.Close_32;
            this.btnCloce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloce.Location = new System.Drawing.Point(954, 508);
            this.btnCloce.Name = "btnCloce";
            this.btnCloce.Size = new System.Drawing.Size(164, 35);
            this.btnCloce.TabIndex = 16;
            this.btnCloce.Text = "Close ";
            this.btnCloce.UseVisualStyleBackColor = true;
            this.btnCloce.Click += new System.EventHandler(this.btnCloce_Click);
            // 
            // dgvManageReservation
            // 
            this.dgvManageReservation.AllowUserToAddRows = false;
            this.dgvManageReservation.AllowUserToDeleteRows = false;
            this.dgvManageReservation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvManageReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageReservation.ContextMenuStrip = this.cmsReservations;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageReservation.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageReservation.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvManageReservation.Location = new System.Drawing.Point(12, 292);
            this.dgvManageReservation.Name = "dgvManageReservation";
            this.dgvManageReservation.ReadOnly = true;
            this.dgvManageReservation.Size = new System.Drawing.Size(1106, 205);
            this.dgvManageReservation.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Reservation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Mnagement_System.Properties.Resources.appointment_edit__72;
            this.pictureBox1.Location = new System.Drawing.Point(508, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.lblWithGroup);
            this.gbCustomerInfo.Controls.Add(this.label22);
            this.gbCustomerInfo.Controls.Add(this.lblFullName);
            this.gbCustomerInfo.Controls.Add(this.label10);
            this.gbCustomerInfo.Controls.Add(this.lblDataFrom);
            this.gbCustomerInfo.Controls.Add(this.lblVisitNumber);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerID);
            this.gbCustomerInfo.Controls.Add(this.label8);
            this.gbCustomerInfo.Controls.Add(this.label7);
            this.gbCustomerInfo.Controls.Add(this.label6);
            this.gbCustomerInfo.Controls.Add(this.label5);
            this.gbCustomerInfo.Controls.Add(this.label4);
            this.gbCustomerInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(480, 172);
            this.gbCustomerInfo.TabIndex = 20;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "Customer Info";
            // 
            // lblWithGroup
            // 
            this.lblWithGroup.AutoSize = true;
            this.lblWithGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithGroup.Location = new System.Drawing.Point(394, 93);
            this.lblWithGroup.Name = "lblWithGroup";
            this.lblWithGroup.Size = new System.Drawing.Size(59, 19);
            this.lblWithGroup.TabIndex = 11;
            this.lblWithGroup.Text = "[????]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(278, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 19);
            this.label22.TabIndex = 10;
            this.label22.Text = "With Group :";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(106, 132);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(59, 19);
            this.lblFullName.TabIndex = 9;
            this.lblFullName.Text = "[????]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(106, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "[????]";
            // 
            // lblDataFrom
            // 
            this.lblDataFrom.AutoSize = true;
            this.lblDataFrom.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFrom.ForeColor = System.Drawing.Color.Red;
            this.lblDataFrom.Location = new System.Drawing.Point(106, 35);
            this.lblDataFrom.Name = "lblDataFrom";
            this.lblDataFrom.Size = new System.Drawing.Size(59, 19);
            this.lblDataFrom.TabIndex = 7;
            this.lblDataFrom.Text = "[????]";
            // 
            // lblVisitNumber
            // 
            this.lblVisitNumber.AutoSize = true;
            this.lblVisitNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitNumber.Location = new System.Drawing.Point(394, 55);
            this.lblVisitNumber.Name = "lblVisitNumber";
            this.lblVisitNumber.Size = new System.Drawing.Size(59, 19);
            this.lblVisitNumber.TabIndex = 6;
            this.lblVisitNumber.Text = "[????]";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(394, 23);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(59, 19);
            this.lblCustomerID.TabIndex = 5;
            this.lblCustomerID.Text = "[????]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hes Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Visit Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date To :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date From :";
            // 
            // gbRoomInfo
            // 
            this.gbRoomInfo.Controls.Add(this.lblFeesForMonth);
            this.gbRoomInfo.Controls.Add(this.label15);
            this.gbRoomInfo.Controls.Add(this.lblStatus);
            this.gbRoomInfo.Controls.Add(this.lblRoomID);
            this.gbRoomInfo.Controls.Add(this.lblTypeRoom);
            this.gbRoomInfo.Controls.Add(this.lblFeesForDay);
            this.gbRoomInfo.Controls.Add(this.label17);
            this.gbRoomInfo.Controls.Add(this.label18);
            this.gbRoomInfo.Controls.Add(this.label19);
            this.gbRoomInfo.Controls.Add(this.label20);
            this.gbRoomInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbRoomInfo.Location = new System.Drawing.Point(699, 12);
            this.gbRoomInfo.Name = "gbRoomInfo";
            this.gbRoomInfo.Size = new System.Drawing.Size(414, 172);
            this.gbRoomInfo.TabIndex = 21;
            this.gbRoomInfo.TabStop = false;
            this.gbRoomInfo.Text = "Room nfo";
            this.gbRoomInfo.Enter += new System.EventHandler(this.gbRoomInfo_Enter);
            // 
            // lblFeesForMonth
            // 
            this.lblFeesForMonth.AutoSize = true;
            this.lblFeesForMonth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeesForMonth.Location = new System.Drawing.Point(156, 143);
            this.lblFeesForMonth.Name = "lblFeesForMonth";
            this.lblFeesForMonth.Size = new System.Drawing.Size(59, 19);
            this.lblFeesForMonth.TabIndex = 30;
            this.lblFeesForMonth.Text = "[????]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 19);
            this.label15.TabIndex = 29;
            this.label15.Text = "Fees For Month :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(156, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 19);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "[????]";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.ForeColor = System.Drawing.Color.Red;
            this.lblRoomID.Location = new System.Drawing.Point(156, 19);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(59, 19);
            this.lblRoomID.TabIndex = 27;
            this.lblRoomID.Text = "[????]";
            // 
            // lblTypeRoom
            // 
            this.lblTypeRoom.AutoSize = true;
            this.lblTypeRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeRoom.Location = new System.Drawing.Point(156, 78);
            this.lblTypeRoom.Name = "lblTypeRoom";
            this.lblTypeRoom.Size = new System.Drawing.Size(59, 19);
            this.lblTypeRoom.TabIndex = 26;
            this.lblTypeRoom.Text = "[????]";
            // 
            // lblFeesForDay
            // 
            this.lblFeesForDay.AutoSize = true;
            this.lblFeesForDay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeesForDay.Location = new System.Drawing.Point(156, 110);
            this.lblFeesForDay.Name = "lblFeesForDay";
            this.lblFeesForDay.Size = new System.Drawing.Size(59, 19);
            this.lblFeesForDay.TabIndex = 25;
            this.lblFeesForDay.Text = "[????]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 19);
            this.label17.TabIndex = 24;
            this.label17.Text = "Type Room :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 19);
            this.label18.TabIndex = 23;
            this.label18.Text = "Status:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 19);
            this.label19.TabIndex = 22;
            this.label19.Text = "Fees For Day :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(8, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 19);
            this.label20.TabIndex = 21;
            this.label20.Text = "Room ID :";
            // 
            // btnAddNewReservation
            // 
            this.btnAddNewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewReservation.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAddNewReservation.Image = global::Hotel_Mnagement_System.Properties.Resources.Save_32;
            this.btnAddNewReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewReservation.Location = new System.Drawing.Point(859, 216);
            this.btnAddNewReservation.Name = "btnAddNewReservation";
            this.btnAddNewReservation.Size = new System.Drawing.Size(259, 35);
            this.btnAddNewReservation.TabIndex = 23;
            this.btnAddNewReservation.Text = "Add New Reservation";
            this.btnAddNewReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewReservation.UseVisualStyleBackColor = true;
            this.btnAddNewReservation.Click += new System.EventHandler(this.btnAddNewReservation_Click);
            // 
            // btnExpireBookingForTomorrow
            // 
            this.btnExpireBookingForTomorrow.BackColor = System.Drawing.Color.White;
            this.btnExpireBookingForTomorrow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExpireBookingForTomorrow.ForeColor = System.Drawing.Color.Black;
            this.btnExpireBookingForTomorrow.Location = new System.Drawing.Point(6, 23);
            this.btnExpireBookingForTomorrow.Name = "btnExpireBookingForTomorrow";
            this.btnExpireBookingForTomorrow.Size = new System.Drawing.Size(138, 37);
            this.btnExpireBookingForTomorrow.TabIndex = 24;
            this.btnExpireBookingForTomorrow.Text = ">=Tomorrow";
            this.btnExpireBookingForTomorrow.UseVisualStyleBackColor = false;
            // 
            // Guna2npExpireBookingForTomorrow
            // 
            this.Guna2npExpireBookingForTomorrow.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.MiddleRight;
            this.Guna2npExpireBookingForTomorrow.BorderColor = System.Drawing.Color.SlateBlue;
            this.Guna2npExpireBookingForTomorrow.FillColor = System.Drawing.Color.Red;
            this.Guna2npExpireBookingForTomorrow.Location = new System.Drawing.Point(120, 9);
            this.Guna2npExpireBookingForTomorrow.TargetControl = this.btnExpireBookingForTomorrow;
            // 
            // gbExpireBooking
            // 
            this.gbExpireBooking.BackColor = System.Drawing.Color.PowderBlue;
            this.gbExpireBooking.Controls.Add(this.btnExpiredBooking);
            this.gbExpireBooking.Controls.Add(this.btnExpireBookingForTomorrow);
            this.gbExpireBooking.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gbExpireBooking.Location = new System.Drawing.Point(578, 215);
            this.gbExpireBooking.Name = "gbExpireBooking";
            this.gbExpireBooking.Size = new System.Drawing.Size(275, 71);
            this.gbExpireBooking.TabIndex = 25;
            this.gbExpireBooking.TabStop = false;
            this.gbExpireBooking.Text = "Expire Booking";
            // 
            // btnExpiredBooking
            // 
            this.btnExpiredBooking.BackColor = System.Drawing.Color.White;
            this.btnExpiredBooking.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExpiredBooking.ForeColor = System.Drawing.Color.Black;
            this.btnExpiredBooking.Location = new System.Drawing.Point(150, 23);
            this.btnExpiredBooking.Name = "btnExpiredBooking";
            this.btnExpiredBooking.Size = new System.Drawing.Size(119, 37);
            this.btnExpiredBooking.TabIndex = 25;
            this.btnExpiredBooking.Text = "Expired";
            this.btnExpiredBooking.UseVisualStyleBackColor = false;
            // 
            // guna2npExpiredBooking
            // 
            this.guna2npExpiredBooking.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.MiddleRight;
            this.guna2npExpiredBooking.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2npExpiredBooking.FillColor = System.Drawing.Color.Red;
            this.guna2npExpiredBooking.Location = new System.Drawing.Point(101, 9);
            this.guna2npExpiredBooking.TargetControl = this.btnExpiredBooking;
            // 
            // btnRenewReservation
            // 
            this.btnRenewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenewReservation.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRenewReservation.Image = global::Hotel_Mnagement_System.Properties.Resources.Save_32;
            this.btnRenewReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenewReservation.Location = new System.Drawing.Point(859, 251);
            this.btnRenewReservation.Name = "btnRenewReservation";
            this.btnRenewReservation.Size = new System.Drawing.Size(259, 35);
            this.btnRenewReservation.TabIndex = 26;
            this.btnRenewReservation.Text = "Renew Reservation";
            this.btnRenewReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenewReservation.UseVisualStyleBackColor = true;
            this.btnRenewReservation.Click += new System.EventHandler(this.btnRenewReservation_Click);
            // 
            // frmManageListReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 551);
            this.Controls.Add(this.btnRenewReservation);
            this.Controls.Add(this.gbExpireBooking);
            this.Controls.Add(this.btnAddNewReservation);
            this.Controls.Add(this.gbRoomInfo);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilteringText);
            this.Controls.Add(this.cmbFilterReservation);
            this.Controls.Add(this.btnCloce);
            this.Controls.Add(this.dgvManageReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageListReservations";
            this.Text = "Manage List Reservations";
            this.Load += new System.EventHandler(this.frmManageListReservations_Load);
            this.cmsReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.gbRoomInfo.ResumeLayout(false);
            this.gbRoomInfo.PerformLayout();
            this.gbExpireBooking.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tmsiDeleteEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditReservations;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetalis;
        private System.Windows.Forms.ContextMenuStrip cmsReservations;
        private System.Windows.Forms.TextBox txtFilteringText;
        private System.Windows.Forms.ComboBox cmbFilterReservation;
        private System.Windows.Forms.Button btnCloce;
        private System.Windows.Forms.DataGridView dgvManageReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.GroupBox gbRoomInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDataFrom;
        private System.Windows.Forms.Label lblVisitNumber;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblWithGroup;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnAddNewReservation;
        private System.Windows.Forms.Label lblFeesForMonth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblTypeRoom;
        private System.Windows.Forms.Label lblFeesForDay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnExpireBookingForTomorrow;
        private Guna.UI2.WinForms.Guna2NotificationPaint Guna2npExpireBookingForTomorrow;
        private System.Windows.Forms.GroupBox gbExpireBooking;
        private System.Windows.Forms.Button btnExpiredBooking;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2npExpiredBooking;
        private System.Windows.Forms.Button btnRenewReservation;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
    }
}