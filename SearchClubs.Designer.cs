namespace Clubs_Management_System
{
    partial class SearchClubs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboClubName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstClubInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1784, 274);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Clubs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(389, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Club Name:";
            // 
            // cboClubName
            // 
            this.cboClubName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClubName.FormattingEnabled = true;
            this.cboClubName.Location = new System.Drawing.Point(720, 451);
            this.cboClubName.Name = "cboClubName";
            this.cboClubName.Size = new System.Drawing.Size(678, 50);
            this.cboClubName.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(0, 1088);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(1784, 207);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Click Here or Hit Enter To Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lstClubInfo
            // 
            this.lstClubInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstClubInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClubInfo.FormattingEnabled = true;
            this.lstClubInfo.ItemHeight = 31;
            this.lstClubInfo.Location = new System.Drawing.Point(720, 583);
            this.lstClubInfo.Name = "lstClubInfo";
            this.lstClubInfo.Size = new System.Drawing.Size(678, 469);
            this.lstClubInfo.TabIndex = 8;
            // 
            // SearchClubs
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 1295);
            this.Controls.Add(this.lstClubInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboClubName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "SearchClubs";
            this.Text = "Search Clubs";
            this.Load += new System.EventHandler(this.SearchClubs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClubName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstClubInfo;
    }
}