namespace Hotel_Mnagement_System.Repotrs
{
    partial class frmListReports
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
            this.manageFinancialReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOtherReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageFinancialReportsToolStripMenuItem,
            this.manageOtherReportsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(933, 72);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // manageFinancialReportsToolStripMenuItem
            // 
            this.manageFinancialReportsToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Manage_Reserva_appointment_64;
            this.manageFinancialReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageFinancialReportsToolStripMenuItem.Name = "manageFinancialReportsToolStripMenuItem";
            this.manageFinancialReportsToolStripMenuItem.Size = new System.Drawing.Size(231, 68);
            this.manageFinancialReportsToolStripMenuItem.Text = "Financial Reports";
            // 
            // manageOtherReportsToolStripMenuItem
            // 
            this.manageOtherReportsToolStripMenuItem.Image = global::Hotel_Mnagement_System.Properties.Resources.Manage_Room_64;
            this.manageOtherReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageOtherReportsToolStripMenuItem.Name = "manageOtherReportsToolStripMenuItem";
            this.manageOtherReportsToolStripMenuItem.Size = new System.Drawing.Size(204, 68);
            this.manageOtherReportsToolStripMenuItem.Text = "Other Reports";
            // 
            // frmListReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListReports";
            this.Text = " List Reports";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem manageFinancialReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOtherReportsToolStripMenuItem;
    }
}