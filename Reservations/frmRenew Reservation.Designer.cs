namespace Hotel_Mnagement_System.Reservations
{
    partial class frmRenew_Reservation
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
            this.btnRenewReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManageReservation = new System.Windows.Forms.DataGridView();
            this.cmsReservations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRenewReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageReservation)).BeginInit();
            this.cmsReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRenewReservation
            // 
            this.btnRenewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenewReservation.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRenewReservation.Image = global::Hotel_Mnagement_System.Properties.Resources.Save_32;
            this.btnRenewReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenewReservation.Location = new System.Drawing.Point(3, 130);
            this.btnRenewReservation.Name = "btnRenewReservation";
            this.btnRenewReservation.Size = new System.Drawing.Size(259, 35);
            this.btnRenewReservation.TabIndex = 33;
            this.btnRenewReservation.Text = "Renew Reservation";
            this.btnRenewReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenewReservation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Manage Reservation";
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
            this.dgvManageReservation.Location = new System.Drawing.Point(3, 171);
            this.dgvManageReservation.Name = "dgvManageReservation";
            this.dgvManageReservation.ReadOnly = true;
            this.dgvManageReservation.Size = new System.Drawing.Size(1106, 205);
            this.dgvManageReservation.TabIndex = 34;
            // 
            // cmsReservations
            // 
            this.cmsReservations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsReservations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRenewReservation,
            this.toolStripSeparator1});
            this.cmsReservations.Name = "cmsEmployees";
            this.cmsReservations.Size = new System.Drawing.Size(230, 70);
            this.cmsReservations.Text = "Reservations";
            // 
            // tsmiRenewReservation
            // 
            this.tsmiRenewReservation.Image = global::Hotel_Mnagement_System.Properties.Resources.appointment_edit_32;
            this.tsmiRenewReservation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiRenewReservation.Name = "tsmiRenewReservation";
            this.tsmiRenewReservation.Size = new System.Drawing.Size(229, 38);
            this.tsmiRenewReservation.Text = "Renew Reservation";
            this.tsmiRenewReservation.Click += new System.EventHandler(this.tsmiRenewReservation_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblRecordCount.Location = new System.Drawing.Point(154, 406);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(51, 23);
            this.lblRecordCount.TabIndex = 37;
            this.lblRecordCount.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(12, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Count Record:";
            // 
            // btnCloce
            // 
            this.btnCloce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloce.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCloce.Image = global::Hotel_Mnagement_System.Properties.Resources.Close_32;
            this.btnCloce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloce.Location = new System.Drawing.Point(945, 403);
            this.btnCloce.Name = "btnCloce";
            this.btnCloce.Size = new System.Drawing.Size(164, 35);
            this.btnCloce.TabIndex = 38;
            this.btnCloce.Text = "Close ";
            this.btnCloce.UseVisualStyleBackColor = true;
            this.btnCloce.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRenew_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 450);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloce);
            this.Controls.Add(this.dgvManageReservation);
            this.Controls.Add(this.btnRenewReservation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRenew_Reservation";
            this.Text = "frmRenew_Reservation";
            this.Load += new System.EventHandler(this.frmRenew_Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageReservation)).EndInit();
            this.cmsReservations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenewReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManageReservation;
        private System.Windows.Forms.ContextMenuStrip cmsReservations;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenewReservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloce;
    }
}