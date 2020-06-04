namespace Clubs_Management_System
{
    partial class DeregisterClub
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pickerDeregisterationDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeregisterClub = new System.Windows.Forms.Button();
            this.cmbClubName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date of Deregistration:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 41);
            this.label4.TabIndex = 13;
            this.label4.Text = "Club Name:";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2379, 240);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select the Club you would like to Deregister";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pickerDeregisterationDate
            // 
            this.pickerDeregisterationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickerDeregisterationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerDeregisterationDate.Location = new System.Drawing.Point(495, 229);
            this.pickerDeregisterationDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.pickerDeregisterationDate.Name = "pickerDeregisterationDate";
            this.pickerDeregisterationDate.Size = new System.Drawing.Size(902, 44);
            this.pickerDeregisterationDate.TabIndex = 11;
            // 
            // btnDeregisterClub
            // 
            this.btnDeregisterClub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeregisterClub.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeregisterClub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeregisterClub.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeregisterClub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeregisterClub.Location = new System.Drawing.Point(0, 987);
            this.btnDeregisterClub.Name = "btnDeregisterClub";
            this.btnDeregisterClub.Size = new System.Drawing.Size(2379, 242);
            this.btnDeregisterClub.TabIndex = 10;
            this.btnDeregisterClub.Text = "Click Here or Hit Enter To Deregister Club";
            this.btnDeregisterClub.UseVisualStyleBackColor = false;
            this.btnDeregisterClub.Click += new System.EventHandler(this.btnDeregisterClub_Click);
            // 
            // cmbClubName
            // 
            this.cmbClubName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClubName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClubName.FormattingEnabled = true;
            this.cmbClubName.Items.AddRange(new object[] {
            "-Select Club"});
            this.cmbClubName.Location = new System.Drawing.Point(495, 3);
            this.cmbClubName.Name = "cmbClubName";
            this.cmbClubName.Size = new System.Drawing.Size(902, 45);
            this.cmbClubName.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.2065F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.7935F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbClubName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pickerDeregisterationDate, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(457, 476);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1400, 452);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1120, 427);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // DeregisterClub
            // 
            this.AcceptButton = this.btnDeregisterClub;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2379, 1229);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeregisterClub);
            this.MaximizeBox = false;
            this.Name = "DeregisterClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Deregister Club";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeregisterClub_FormClosing);
            this.Load += new System.EventHandler(this.DeregisterClub_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pickerDeregisterationDate;
        private System.Windows.Forms.Button btnDeregisterClub;
        private System.Windows.Forms.ComboBox cmbClubName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}