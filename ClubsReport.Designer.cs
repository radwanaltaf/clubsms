namespace Clubs_Management_System
{
    partial class ClubsReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.gridClubs = new System.Windows.Forms.DataGridView();
            this.btnReportClubs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2398, 240);
            this.label3.TabIndex = 13;
            this.label3.Text = "Report on Clubs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gridClubs
            // 
            this.gridClubs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClubs.Location = new System.Drawing.Point(212, 422);
            this.gridClubs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridClubs.Name = "gridClubs";
            this.gridClubs.RowHeadersWidth = 51;
            this.gridClubs.RowTemplate.Height = 24;
            this.gridClubs.Size = new System.Drawing.Size(1982, 583);
            this.gridClubs.TabIndex = 14;
            // 
            // btnReportClubs
            // 
            this.btnReportClubs.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReportClubs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReportClubs.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportClubs.Location = new System.Drawing.Point(0, 1068);
            this.btnReportClubs.Name = "btnReportClubs";
            this.btnReportClubs.Size = new System.Drawing.Size(2398, 177);
            this.btnReportClubs.TabIndex = 18;
            this.btnReportClubs.Text = "Click Here or Hit Enter To Generate a Report";
            this.btnReportClubs.UseVisualStyleBackColor = false;
            // 
            // ClubsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2398, 1245);
            this.Controls.Add(this.btnReportClubs);
            this.Controls.Add(this.gridClubs);
            this.Controls.Add(this.label3);
            this.Name = "ClubsReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ClubsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridClubs;
        private System.Windows.Forms.Button btnReportClubs;
    }
}