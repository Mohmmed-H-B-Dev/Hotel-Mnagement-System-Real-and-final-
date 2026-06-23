namespace Hotel_Mnagement_System.Rooms
{
    partial class frmManageListRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilteringText = new System.Windows.Forms.TextBox();
            this.cmbFilterRooms = new System.Windows.Forms.ComboBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvManageRoom = new System.Windows.Forms.DataGridView();
            this.cmsRooms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChooseRoomtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbStatusRoom = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnaddroom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageRoom)).BeginInit();
            this.cmsRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Rooms";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Mnagement_System.Properties.Resources.Manage_Room_72;
            this.pictureBox1.Location = new System.Drawing.Point(409, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(11, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter By :";
            // 
            // txtFilteringText
            // 
            this.txtFilteringText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFilteringText.Location = new System.Drawing.Point(374, 195);
            this.txtFilteringText.Name = "txtFilteringText";
            this.txtFilteringText.Size = new System.Drawing.Size(296, 27);
            this.txtFilteringText.TabIndex = 11;
            this.txtFilteringText.Visible = false;
            this.txtFilteringText.TextChanged += new System.EventHandler(this.txtFilteringText_TextChanged);
            this.txtFilteringText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilteringText_KeyPress);
            // 
            // cmbFilterRooms
            // 
            this.cmbFilterRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRooms.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFilterRooms.FormattingEnabled = true;
            this.cmbFilterRooms.Items.AddRange(new object[] {
            "None",
            "Room ID",
            "Type Room",
            "Status"});
            this.cmbFilterRooms.Location = new System.Drawing.Point(113, 195);
            this.cmbFilterRooms.Name = "cmbFilterRooms";
            this.cmbFilterRooms.Size = new System.Drawing.Size(195, 27);
            this.cmbFilterRooms.TabIndex = 10;
            this.cmbFilterRooms.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRooms_SelectedIndexChanged);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblRecordCount.Location = new System.Drawing.Point(150, 475);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(51, 23);
            this.lblRecordCount.TabIndex = 15;
            this.lblRecordCount.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(8, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Count Record:";
            // 
            // dgvManageRoom
            // 
            this.dgvManageRoom.AllowUserToAddRows = false;
            this.dgvManageRoom.AllowUserToDeleteRows = false;
            this.dgvManageRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvManageRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageRoom.ContextMenuStrip = this.cmsRooms;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageRoom.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvManageRoom.Location = new System.Drawing.Point(12, 231);
            this.dgvManageRoom.Name = "dgvManageRoom";
            this.dgvManageRoom.ReadOnly = true;
            this.dgvManageRoom.Size = new System.Drawing.Size(1104, 240);
            this.dgvManageRoom.TabIndex = 13;
            // 
            // cmsRooms
            // 
            this.cmsRooms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseRoomtoolStripMenuItem});
            this.cmsRooms.Name = "contextMenuStrip1";
            this.cmsRooms.Size = new System.Drawing.Size(209, 42);
            // 
            // ChooseRoomtoolStripMenuItem
            // 
            this.ChooseRoomtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.ChooseRoomtoolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Save_Room_32;
            this.ChooseRoomtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChooseRoomtoolStripMenuItem.Name = "ChooseRoomtoolStripMenuItem";
            this.ChooseRoomtoolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.ChooseRoomtoolStripMenuItem.Text = "Choose Room";
            this.ChooseRoomtoolStripMenuItem.Click += new System.EventHandler(this.ChooseRoomtoolStripMenuItem_Click);
            // 
            // cmbStatusRoom
            // 
            this.cmbStatusRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusRoom.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbStatusRoom.FormattingEnabled = true;
            this.cmbStatusRoom.Items.AddRange(new object[] {
            "All",
            "Rented",
            "Unrented"});
            this.cmbStatusRoom.Location = new System.Drawing.Point(327, 195);
            this.cmbStatusRoom.Name = "cmbStatusRoom";
            this.cmbStatusRoom.Size = new System.Drawing.Size(195, 27);
            this.cmbStatusRoom.TabIndex = 16;
            this.cmbStatusRoom.SelectedIndexChanged += new System.EventHandler(this.cbStatusRoom_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::Hotel_Mnagement_System.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(981, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 114;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnaddroom
            // 
            this.btnaddroom.BackColor = System.Drawing.Color.White;
            this.btnaddroom.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnaddroom.Location = new System.Drawing.Point(924, 189);
            this.btnaddroom.Name = "btnaddroom";
            this.btnaddroom.Size = new System.Drawing.Size(192, 36);
            this.btnaddroom.TabIndex = 115;
            this.btnaddroom.Text = "Add RoomTo Sestem";
            this.btnaddroom.UseVisualStyleBackColor = false;
            this.btnaddroom.Click += new System.EventHandler(this.btnaddroom_Click);
            // 
            // frmManageListRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 519);
            this.Controls.Add(this.btnaddroom);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbStatusRoom);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvManageRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilteringText);
            this.Controls.Add(this.cmbFilterRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageListRooms";
            this.Text = "Manage List Rooms";
            this.Load += new System.EventHandler(this.frmManageListRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageRoom)).EndInit();
            this.cmsRooms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilteringText;
        private System.Windows.Forms.ComboBox cmbFilterRooms;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvManageRoom;
        private System.Windows.Forms.ComboBox cmbStatusRoom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnaddroom;
        private System.Windows.Forms.ContextMenuStrip cmsRooms;
        private System.Windows.Forms.ToolStripMenuItem ChooseRoomtoolStripMenuItem;
    }
}