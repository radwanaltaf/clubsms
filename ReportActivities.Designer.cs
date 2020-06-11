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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsClubs = new Clubs_Management_System.dsClubs();
            this.ClubActivitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClubActivitiesTableAdapter = new Clubs_Management_System.dsClubsTableAdapters.ClubActivitiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubActivitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2710, 263);
            this.label3.TabIndex = 15;
            this.label3.Text = "Report on Club Activities for the Week";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ActRep";
            reportDataSource1.Value = this.ClubActivitiesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clubs_Management_System.ClubsActivitiesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(568, 383);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1700, 853);
            this.reportViewer1.TabIndex = 21;
            // 
            // dsClubs
            // 
            this.dsClubs.DataSetName = "dsClubs";
            this.dsClubs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClubActivitiesBindingSource
            // 
            this.ClubActivitiesBindingSource.DataMember = "ClubActivities";
            this.ClubActivitiesBindingSource.DataSource = this.dsClubs;
            // 
            // ClubActivitiesTableAdapter
            // 
            this.ClubActivitiesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(2710, 1345);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Name = "ReportActivities";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubActivitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClubActivitiesBindingSource;
        private dsClubs dsClubs;
        private dsClubsTableAdapters.ClubActivitiesTableAdapter ClubActivitiesTableAdapter;
    }
}