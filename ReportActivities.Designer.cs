namespace Clubs_Management_System
{
    partial class ReportActivities
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
            this.gridClubActivities = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReportActivities = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClubActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClubActivities
            // 
            this.gridClubActivities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClubActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClubActivities.Location = new System.Drawing.Point(241, 399);
            this.gridClubActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridClubActivities.Name = "gridClubActivities";
            this.gridClubActivities.RowHeadersWidth = 51;
            this.gridClubActivities.RowTemplate.Height = 24;
            this.gridClubActivities.Size = new System.Drawing.Size(1982, 706);
            this.gridClubActivities.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2460, 271);
            this.label3.TabIndex = 15;
            this.label3.Text = "Report on Club Activities For the Week";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnReportActivities
            // 
            this.btnReportActivities.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReportActivities.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReportActivities.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportActivities.Location = new System.Drawing.Point(0, 1129);
            this.btnReportActivities.Name = "btnReportActivities";
            this.btnReportActivities.Size = new System.Drawing.Size(2460, 177);
            this.btnReportActivities.TabIndex = 17;
            this.btnReportActivities.Text = "Click Here or Hit Enter To Generate a Report";
            this.btnReportActivities.UseVisualStyleBackColor = false;
            // 
            // ReportActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2460, 1306);
            this.Controls.Add(this.btnReportActivities);
            this.Controls.Add(this.gridClubActivities);
            this.Controls.Add(this.label3);
            this.Name = "ReportActivities";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportActivities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClubActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClubActivities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReportActivities;
    }
}