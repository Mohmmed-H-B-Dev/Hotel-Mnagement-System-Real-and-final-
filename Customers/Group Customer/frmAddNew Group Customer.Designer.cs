namespace Hotel_Mnagement_System.Customers.Group_Customer
{
    partial class frmAddNew_Group_Customer
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
            this.btnAddGruop = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtTotalMembers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecialRequests = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreatedByUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbGroupCustomerInfo = new System.Windows.Forms.GroupBox();
            this.nudTotalMembers = new System.Windows.Forms.NumericUpDown();
            this.ctrlCustomerCard1 = new DVLD.Controls.ctrlCustomerCard();
            this.gbGroupCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddGruop
            // 
            this.btnAddGruop.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddGruop.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGruop.ForeColor = System.Drawing.Color.Black;
            this.btnAddGruop.Image = global::Hotel_Mnagement_System.Properties.Resources.customers_add_64;
            this.btnAddGruop.Location = new System.Drawing.Point(358, 0);
            this.btnAddGruop.Name = "btnAddGruop";
            this.btnAddGruop.Size = new System.Drawing.Size(78, 79);
            this.btnAddGruop.TabIndex = 5;
            this.btnAddGruop.Text = "Gruop";
            this.btnAddGruop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGruop.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTitle.Location = new System.Drawing.Point(248, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 33);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Add New / Find Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCustomerID.Location = new System.Drawing.Point(149, 58);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(139, 27);
            this.txtCustomerID.TabIndex = 8;
            // 
            // txtTotalMembers
            // 
            this.txtTotalMembers.Enabled = false;
            this.txtTotalMembers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTotalMembers.Location = new System.Drawing.Point(149, 128);
            this.txtTotalMembers.Name = "txtTotalMembers";
            this.txtTotalMembers.ReadOnly = true;
            this.txtTotalMembers.Size = new System.Drawing.Size(123, 27);
            this.txtTotalMembers.TabIndex = 10;
            this.txtTotalMembers.Text = "1";
            this.txtTotalMembers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalMembers_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Members:";
            // 
            // txtSpecialRequests
            // 
            this.txtSpecialRequests.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSpecialRequests.Location = new System.Drawing.Point(149, 187);
            this.txtSpecialRequests.Multiline = true;
            this.txtSpecialRequests.Name = "txtSpecialRequests";
            this.txtSpecialRequests.Size = new System.Drawing.Size(139, 155);
            this.txtSpecialRequests.TabIndex = 12;
            this.txtSpecialRequests.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sp Requests :";
            // 
            // txtCreatedByUserID
            // 
            this.txtCreatedByUserID.Enabled = false;
            this.txtCreatedByUserID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCreatedByUserID.Location = new System.Drawing.Point(149, 93);
            this.txtCreatedByUserID.Name = "txtCreatedByUserID";
            this.txtCreatedByUserID.ReadOnly = true;
            this.txtCreatedByUserID.Size = new System.Drawing.Size(139, 27);
            this.txtCreatedByUserID.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "User ID :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.Image = global::Hotel_Mnagement_System.Properties.Resources.Close_64;
            this.btnClose.Location = new System.Drawing.Point(1, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 79);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Image = global::Hotel_Mnagement_System.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(254, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(78, 79);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbGroupCustomerInfo
            // 
            this.gbGroupCustomerInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbGroupCustomerInfo.Controls.Add(this.nudTotalMembers);
            this.gbGroupCustomerInfo.Controls.Add(this.txtSpecialRequests);
            this.gbGroupCustomerInfo.Controls.Add(this.label1);
            this.gbGroupCustomerInfo.Controls.Add(this.txtCustomerID);
            this.gbGroupCustomerInfo.Controls.Add(this.txtCreatedByUserID);
            this.gbGroupCustomerInfo.Controls.Add(this.label2);
            this.gbGroupCustomerInfo.Controls.Add(this.label4);
            this.gbGroupCustomerInfo.Controls.Add(this.txtTotalMembers);
            this.gbGroupCustomerInfo.Controls.Add(this.label3);
            this.gbGroupCustomerInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbGroupCustomerInfo.Location = new System.Drawing.Point(12, 120);
            this.gbGroupCustomerInfo.Name = "gbGroupCustomerInfo";
            this.gbGroupCustomerInfo.Size = new System.Drawing.Size(332, 348);
            this.gbGroupCustomerInfo.TabIndex = 49;
            this.gbGroupCustomerInfo.TabStop = false;
            this.gbGroupCustomerInfo.Text = "Group Customer ";
            // 
            // nudTotalMembers
            // 
            this.nudTotalMembers.Location = new System.Drawing.Point(278, 129);
            this.nudTotalMembers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudTotalMembers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTotalMembers.Name = "nudTotalMembers";
            this.nudTotalMembers.Size = new System.Drawing.Size(54, 27);
            this.nudTotalMembers.TabIndex = 50;
            this.nudTotalMembers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTotalMembers.ValueChanged += new System.EventHandler(this.nudTotalMembers_ValueChanged);
            // 
            // ctrlCustomerCard1
            // 
            this.ctrlCustomerCard1.BackColor = System.Drawing.Color.Silver;
            this.ctrlCustomerCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCustomerCard1.Location = new System.Drawing.Point(343, 120);
            this.ctrlCustomerCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlCustomerCard1.Name = "ctrlCustomerCard1";
            this.ctrlCustomerCard1.Size = new System.Drawing.Size(626, 469);
            this.ctrlCustomerCard1.TabIndex = 0;
            // 
            // frmAddNew_Group_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(973, 595);
            this.Controls.Add(this.gbGroupCustomerInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddGruop);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlCustomerCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNew_Group_Customer";
            this.Text = "Add New Group Customer";
            this.Load += new System.EventHandler(this.frmAddNew_Group_Customer_Load);
            this.gbGroupCustomerInfo.ResumeLayout(false);
            this.gbGroupCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DVLD.Controls.ctrlCustomerCard ctrlCustomerCard1;
        private System.Windows.Forms.Button btnAddGruop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtTotalMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpecialRequests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreatedByUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbGroupCustomerInfo;
        private System.Windows.Forms.NumericUpDown nudTotalMembers;
    }
}