namespace Hotel_Mnagement_System.Customers
{
    partial class frmListAddFindCustomers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGroupSepcialRequests = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleSpecialRequests = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnIDNumber = new System.Windows.Forms.RadioButton();
            this.ctrlCustomerCard1 = new DVLD.Controls.ctrlCustomerCard();
            this.txtUpdateSpecialRequests = new System.Windows.Forms.TextBox();
            this.btnUpdateSpecialRequests = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.btnAddGroup);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAddNewCustomer);
            this.groupBox1.Controls.Add(this.txtSearchCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddGroup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddGroup.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.ForeColor = System.Drawing.Color.Black;
            this.btnAddGroup.Image = global::Hotel_Mnagement_System.Properties.Resources.customers_add_64;
            this.btnAddGroup.Location = new System.Drawing.Point(9, 13);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(78, 79);
            this.btnAddGroup.TabIndex = 3;
            this.btnAddGroup.Text = "Group";
            this.btnAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Image = global::Hotel_Mnagement_System.Properties.Resources.search_64;
            this.btnSearch.Location = new System.Drawing.Point(177, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 79);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddNewCustomer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewCustomer.Image = global::Hotel_Mnagement_System.Properties.Resources.customers_add_64;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(93, 13);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(78, 79);
            this.btnAddNewCustomer.TabIndex = 3;
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSearchCustomer.Location = new System.Drawing.Point(261, 13);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(243, 32);
            this.txtSearchCustomer.TabIndex = 1;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            this.txtSearchCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearchCustomer_Validating);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTitle.Location = new System.Drawing.Point(366, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 33);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Add New / Find Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnUpdateSpecialRequests);
            this.groupBox2.Controls.Add(this.btnAddCustomer);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtUpdateSpecialRequests);
            this.groupBox2.Controls.Add(this.lblTitleSpecialRequests);
            this.groupBox2.Controls.Add(this.ctrlCustomerCard1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox2.Location = new System.Drawing.Point(6, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1174, 534);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Manage";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnAddCustomer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddCustomer.Location = new System.Drawing.Point(418, 452);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(112, 70);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGroupSepcialRequests);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblTotalMembers);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblGroupID);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(15, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 144);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Group Customer Info";
            // 
            // txtGroupSepcialRequests
            // 
            this.txtGroupSepcialRequests.Enabled = false;
            this.txtGroupSepcialRequests.Location = new System.Drawing.Point(183, 75);
            this.txtGroupSepcialRequests.Multiline = true;
            this.txtGroupSepcialRequests.Name = "txtGroupSepcialRequests";
            this.txtGroupSepcialRequests.ReadOnly = true;
            this.txtGroupSepcialRequests.Size = new System.Drawing.Size(326, 63);
            this.txtGroupSepcialRequests.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sepcial Reqeusts:";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Location = new System.Drawing.Point(399, 37);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(60, 23);
            this.lblTotalMembers.TabIndex = 3;
            this.lblTotalMembers.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Members :";
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Location = new System.Drawing.Point(120, 37);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(60, 23);
            this.lblGroupID.TabIndex = 1;
            this.lblGroupID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group ID:";
            // 
            // lblTitleSpecialRequests
            // 
            this.lblTitleSpecialRequests.AutoSize = true;
            this.lblTitleSpecialRequests.BackColor = System.Drawing.Color.Black;
            this.lblTitleSpecialRequests.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSpecialRequests.ForeColor = System.Drawing.Color.Snow;
            this.lblTitleSpecialRequests.Location = new System.Drawing.Point(7, 158);
            this.lblTitleSpecialRequests.Name = "lblTitleSpecialRequests";
            this.lblTitleSpecialRequests.Size = new System.Drawing.Size(230, 29);
            this.lblTitleSpecialRequests.TabIndex = 4;
            this.lblTitleSpecialRequests.Text = "Special Requests :";
            this.lblTitleSpecialRequests.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::Hotel_Mnagement_System.Properties.Resources.Close_64;
            this.btnClose.Location = new System.Drawing.Point(14, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 70);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Mnagement_System.Properties.Resources.customers_edit_64;
            this.pictureBox1.Location = new System.Drawing.Point(505, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 70);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.rbtnIDNumber);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox3.Location = new System.Drawing.Point(6, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1174, 46);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By :";
            // 
            // rbtnIDNumber
            // 
            this.rbtnIDNumber.AutoSize = true;
            this.rbtnIDNumber.Checked = true;
            this.rbtnIDNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIDNumber.Location = new System.Drawing.Point(115, 17);
            this.rbtnIDNumber.Name = "rbtnIDNumber";
            this.rbtnIDNumber.Size = new System.Drawing.Size(122, 23);
            this.rbtnIDNumber.TabIndex = 0;
            this.rbtnIDNumber.TabStop = true;
            this.rbtnIDNumber.Text = "ID Numberr";
            this.rbtnIDNumber.UseVisualStyleBackColor = true;
            // 
            // ctrlCustomerCard1
            // 
            this.ctrlCustomerCard1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ctrlCustomerCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCustomerCard1.Location = new System.Drawing.Point(547, 28);
            this.ctrlCustomerCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlCustomerCard1.Name = "ctrlCustomerCard1";
            this.ctrlCustomerCard1.Size = new System.Drawing.Size(627, 473);
            this.ctrlCustomerCard1.TabIndex = 0;
            // 
            // txtUpdateSpecialRequests
            // 
            this.txtUpdateSpecialRequests.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUpdateSpecialRequests.Location = new System.Drawing.Point(12, 204);
            this.txtUpdateSpecialRequests.Multiline = true;
            this.txtUpdateSpecialRequests.Name = "txtUpdateSpecialRequests";
            this.txtUpdateSpecialRequests.Size = new System.Drawing.Size(518, 94);
            this.txtUpdateSpecialRequests.TabIndex = 5;
            // 
            // btnUpdateSpecialRequests
            // 
            this.btnUpdateSpecialRequests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateSpecialRequests.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnUpdateSpecialRequests.Image = global::Hotel_Mnagement_System.Properties.Resources.AddAppointment_32;
            this.btnUpdateSpecialRequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSpecialRequests.Location = new System.Drawing.Point(296, 155);
            this.btnUpdateSpecialRequests.Name = "btnUpdateSpecialRequests";
            this.btnUpdateSpecialRequests.Size = new System.Drawing.Size(234, 40);
            this.btnUpdateSpecialRequests.TabIndex = 29;
            this.btnUpdateSpecialRequests.Text = "Update Special Requests";
            this.btnUpdateSpecialRequests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSpecialRequests.UseVisualStyleBackColor = true;
            this.btnUpdateSpecialRequests.Click += new System.EventHandler(this.btnUpdateSpecialRequests_Click);
            // 
            // frmListAddFindCustomers
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1184, 689);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListAddFindCustomers";
            this.Text = "Add New && Find Customer";
            this.Load += new System.EventHandler(this.frmAddFindCustomers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private DVLD.Controls.ctrlCustomerCard ctrlCustomerCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitleSpecialRequests;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnIDNumber;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupSepcialRequests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtUpdateSpecialRequests;
        private System.Windows.Forms.Button btnUpdateSpecialRequests;
    }
}