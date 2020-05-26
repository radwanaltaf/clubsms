namespace Clubs_Management_System
{
    partial class UpdateClubDescription
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClubDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateClubDesc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstUpdatedDesc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 589);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 56);
            this.label1.TabIndex = 20;
            this.label1.Text = "Updated Club Description:";
            // 
            // txtClubDesc
            // 
            this.txtClubDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClubDesc.Location = new System.Drawing.Point(596, 231);
            this.txtClubDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtClubDesc.Name = "txtClubDesc";
            this.txtClubDesc.Size = new System.Drawing.Size(955, 190);
            this.txtClubDesc.TabIndex = 19;
            this.txtClubDesc.Text = "";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 56);
            this.label4.TabIndex = 15;
            this.label4.Text = "Club Description:";
            // 
            // btnUpdateClubDesc
            // 
            this.btnUpdateClubDesc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateClubDesc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateClubDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateClubDesc.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClubDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateClubDesc.Location = new System.Drawing.Point(0, 1102);
            this.btnUpdateClubDesc.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateClubDesc.Name = "btnUpdateClubDesc";
            this.btnUpdateClubDesc.Size = new System.Drawing.Size(1825, 113);
            this.btnUpdateClubDesc.TabIndex = 14;
            this.btnUpdateClubDesc.Text = "Click Here or Hit Enter To Update Club Description";
            this.btnUpdateClubDesc.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1825, 140);
            this.label3.TabIndex = 13;
            this.label3.Text = "Update Club Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lstUpdatedDesc
            // 
            this.lstUpdatedDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUpdatedDesc.FormattingEnabled = true;
            this.lstUpdatedDesc.ItemHeight = 25;
            this.lstUpdatedDesc.Location = new System.Drawing.Point(596, 532);
            this.lstUpdatedDesc.Name = "lstUpdatedDesc";
            this.lstUpdatedDesc.Size = new System.Drawing.Size(955, 154);
            this.lstUpdatedDesc.TabIndex = 21;
            // 
            // UpdateClubDescription
            // 
            this.AcceptButton = this.btnUpdateClubDesc;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1825, 1215);
            this.Controls.Add(this.lstUpdatedDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClubDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateClubDesc);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateClubDescription";
            this.Text = "Update Club Description";
            this.Load += new System.EventHandler(this.UpdateClubDescription_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtClubDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateClubDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstUpdatedDesc;
    }
}