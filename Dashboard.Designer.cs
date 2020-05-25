namespace Clubs_Management_System
{
    partial class Dashboard
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.registerClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClubsActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClubsDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchClubToolStripMenuItem,
            this.registerClubToolStripMenuItem,
            this.updateClubToolStripMenuItem,
            this.deregisterClubToolStripMenuItem,
            this.clubReportToolStripMenuItem,
            this.activitiesReportToolStripMenuItem,
            this.updateClubsActivitiesToolStripMenuItem,
            this.updateClubsDescriptionToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1992, 48);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // registerClubToolStripMenuItem
            // 
            this.registerClubToolStripMenuItem.Name = "registerClubToolStripMenuItem";
            this.registerClubToolStripMenuItem.Size = new System.Drawing.Size(205, 44);
            this.registerClubToolStripMenuItem.Text = "Register Club";
            // 
            // updateClubToolStripMenuItem
            // 
            this.updateClubToolStripMenuItem.Name = "updateClubToolStripMenuItem";
            this.updateClubToolStripMenuItem.Size = new System.Drawing.Size(197, 44);
            this.updateClubToolStripMenuItem.Text = "Update Club";
            // 
            // deregisterClubToolStripMenuItem
            // 
            this.deregisterClubToolStripMenuItem.Name = "deregisterClubToolStripMenuItem";
            this.deregisterClubToolStripMenuItem.Size = new System.Drawing.Size(234, 44);
            this.deregisterClubToolStripMenuItem.Text = "Deregister Club";
            // 
            // searchClubToolStripMenuItem
            // 
            this.searchClubToolStripMenuItem.Name = "searchClubToolStripMenuItem";
            this.searchClubToolStripMenuItem.Size = new System.Drawing.Size(187, 44);
            this.searchClubToolStripMenuItem.Text = "Search Club";
            // 
            // clubReportToolStripMenuItem
            // 
            this.clubReportToolStripMenuItem.Name = "clubReportToolStripMenuItem";
            this.clubReportToolStripMenuItem.Size = new System.Drawing.Size(188, 44);
            this.clubReportToolStripMenuItem.Text = "Club Report";
            // 
            // activitiesReportToolStripMenuItem
            // 
            this.activitiesReportToolStripMenuItem.Name = "activitiesReportToolStripMenuItem";
            this.activitiesReportToolStripMenuItem.Size = new System.Drawing.Size(244, 44);
            this.activitiesReportToolStripMenuItem.Text = "Activities Report";
            // 
            // updateClubsActivitiesToolStripMenuItem
            // 
            this.updateClubsActivitiesToolStripMenuItem.Name = "updateClubsActivitiesToolStripMenuItem";
            this.updateClubsActivitiesToolStripMenuItem.Size = new System.Drawing.Size(338, 44);
            this.updateClubsActivitiesToolStripMenuItem.Text = "Update Club\'s Activities";
            // 
            // updateClubsDescriptionToolStripMenuItem
            // 
            this.updateClubsDescriptionToolStripMenuItem.Name = "updateClubsDescriptionToolStripMenuItem";
            this.updateClubsDescriptionToolStripMenuItem.Size = new System.Drawing.Size(368, 44);
            this.updateClubsDescriptionToolStripMenuItem.Text = "Update Club\'s Description";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1992, 523);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Dashboard";
            this.Text = "Clubs Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem searchClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClubsActivitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClubsDescriptionToolStripMenuItem;
    }
}

