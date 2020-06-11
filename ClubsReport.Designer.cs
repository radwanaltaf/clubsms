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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClubs = new Clubs_Management_System.dsClubs();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClubsTableAdapter = new Clubs_Management_System.dsClubsTableAdapters.ClubsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClubsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // ClubsBindingSource
            // 
            this.ClubsBindingSource.DataMember = "Clubs";
            this.ClubsBindingSource.DataSource = this.dsClubs;
            // 
            // dsClubs
            // 
            this.dsClubs.DataSetName = "dsClubs";
            this.dsClubs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2676, 261);
            this.label3.TabIndex = 14;
            this.label3.Text = "Report on Clubs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.ClubsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clubs_Management_System.ClubsRepoort.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(599, 415);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1700, 853);
            this.reportViewer1.TabIndex = 20;
            // 
            // ClubsTableAdapter
            // 
            this.ClubsTableAdapter.ClearBeforeFill = true;
            // 
            // ClubsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(2676, 1547);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Name = "ClubsReport";
            this.Text = "Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportClubsss_FormClosing);
            this.Load += new System.EventHandler(this.ReportClubsss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClubsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClubsBindingSource;
        private dsClubs dsClubs;
        private dsClubsTableAdapters.ClubsTableAdapter ClubsTableAdapter;
    }
}