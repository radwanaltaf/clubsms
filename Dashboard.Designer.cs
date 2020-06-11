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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.searchClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClubsActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClubsDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.47735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.52265F));
            this.tableLayoutPanel1.Controls.Add(this.menuStripMain, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2832, 77);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuStripMain.Location = new System.Drawing.Point(137, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMain.Size = new System.Drawing.Size(2554, 58);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // searchClubToolStripMenuItem
            // 
            this.searchClubToolStripMenuItem.Name = "searchClubToolStripMenuItem";
            this.searchClubToolStripMenuItem.Size = new System.Drawing.Size(241, 120);
            this.searchClubToolStripMenuItem.Text = "Search Club";
            this.searchClubToolStripMenuItem.Click += new System.EventHandler(this.searchClubToolStripMenuItem_Click);
            // 
            // registerClubToolStripMenuItem
            // 
            this.registerClubToolStripMenuItem.Name = "registerClubToolStripMenuItem";
            this.registerClubToolStripMenuItem.Size = new System.Drawing.Size(267, 120);
            this.registerClubToolStripMenuItem.Text = "Register Club";
            this.registerClubToolStripMenuItem.Click += new System.EventHandler(this.registerClubToolStripMenuItem_Click);
            // 
            // updateClubToolStripMenuItem
            // 
            this.updateClubToolStripMenuItem.Name = "updateClubToolStripMenuItem";
            this.updateClubToolStripMenuItem.Size = new System.Drawing.Size(251, 120);
            this.updateClubToolStripMenuItem.Text = "Update Club";
            this.updateClubToolStripMenuItem.Click += new System.EventHandler(this.updateClubToolStripMenuItem_Click);
            // 
            // deregisterClubToolStripMenuItem
            // 
            this.deregisterClubToolStripMenuItem.Name = "deregisterClubToolStripMenuItem";
            this.deregisterClubToolStripMenuItem.Size = new System.Drawing.Size(305, 120);
            this.deregisterClubToolStripMenuItem.Text = "Deregister Club";
            this.deregisterClubToolStripMenuItem.Click += new System.EventHandler(this.deregisterClubToolStripMenuItem_Click);
            // 
            // clubReportToolStripMenuItem
            // 
            this.clubReportToolStripMenuItem.Name = "clubReportToolStripMenuItem";
            this.clubReportToolStripMenuItem.Size = new System.Drawing.Size(243, 120);
            this.clubReportToolStripMenuItem.Text = "Club Report";
            this.clubReportToolStripMenuItem.Click += new System.EventHandler(this.clubReportToolStripMenuItem_Click);
            // 
            // activitiesReportToolStripMenuItem
            // 
            this.activitiesReportToolStripMenuItem.Name = "activitiesReportToolStripMenuItem";
            this.activitiesReportToolStripMenuItem.Size = new System.Drawing.Size(319, 120);
            this.activitiesReportToolStripMenuItem.Text = "Activities Report";
            this.activitiesReportToolStripMenuItem.Click += new System.EventHandler(this.activitiesReportToolStripMenuItem_Click);
            // 
            // updateClubsActivitiesToolStripMenuItem
            // 
            this.updateClubsActivitiesToolStripMenuItem.Name = "updateClubsActivitiesToolStripMenuItem";
            this.updateClubsActivitiesToolStripMenuItem.Size = new System.Drawing.Size(440, 120);
            this.updateClubsActivitiesToolStripMenuItem.Text = "Update Club\'s Activities";
            this.updateClubsActivitiesToolStripMenuItem.Click += new System.EventHandler(this.updateClubsActivitiesToolStripMenuItem_Click);
            // 
            // updateClubsDescriptionToolStripMenuItem
            // 
            this.updateClubsDescriptionToolStripMenuItem.Name = "updateClubsDescriptionToolStripMenuItem";
            this.updateClubsDescriptionToolStripMenuItem.Size = new System.Drawing.Size(480, 120);
            this.updateClubsDescriptionToolStripMenuItem.Text = "Update Club\'s Description";
            this.updateClubsDescriptionToolStripMenuItem.Click += new System.EventHandler(this.updateClubsDescriptionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Clubs_Management_System.Properties.Resources.icons8_shutdown_64;
            this.pictureBox1.Location = new System.Drawing.Point(2694, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Clubs_Management_System.Properties.Resources.LogOut1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2832, 779);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Dashboard";
            this.Text = "Clubs Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem searchClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClubsActivitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClubsDescriptionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

