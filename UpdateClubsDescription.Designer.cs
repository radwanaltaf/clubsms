namespace Clubs_Management_System
{
    partial class UpdateClubsDescription
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateClubDesc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClubDesc = new System.Windows.Forms.RichTextBox();
            this.txtDisabledClubName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(832, 56);
            this.label4.TabIndex = 15;
            this.label4.Text = "Your Club:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateClubDesc
            // 
            this.btnUpdateClubDesc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateClubDesc.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateClubDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateClubDesc.FlatAppearance.BorderSize = 0;
            this.btnUpdateClubDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClubDesc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClubDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateClubDesc.Location = new System.Drawing.Point(0, 1263);
            this.btnUpdateClubDesc.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateClubDesc.Name = "btnUpdateClubDesc";
            this.btnUpdateClubDesc.Size = new System.Drawing.Size(2651, 242);
            this.btnUpdateClubDesc.TabIndex = 24;
            this.btnUpdateClubDesc.Text = "Click Here or Hit Enter To Update Club Description";
            this.btnUpdateClubDesc.UseVisualStyleBackColor = false;
            this.btnUpdateClubDesc.Click += new System.EventHandler(this.btnUpdateClubDesc_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2651, 195);
            this.label3.TabIndex = 23;
            this.label3.Text = "Update Club\'s Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.63521F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.36479F));
            this.tableLayoutPanel1.Controls.Add(this.txtDisabledClubName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtClubDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(359, 503);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1961, 654);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 209);
            this.label1.TabIndex = 20;
            this.label1.Text = "Club Description:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClubDesc
            // 
            this.txtClubDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubDesc.Location = new System.Drawing.Point(838, 321);
            this.txtClubDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtClubDesc.Name = "txtClubDesc";
            this.txtClubDesc.Size = new System.Drawing.Size(1107, 321);
            this.txtClubDesc.TabIndex = 21;
            this.txtClubDesc.Text = "Enter New Description";
            this.txtClubDesc.Enter += new System.EventHandler(this.txtClubDesc_Enter);
            this.txtClubDesc.Leave += new System.EventHandler(this.txtClubDesc_Leave);
            // 
            // txtDisabledClubName
            // 
            this.txtDisabledClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisabledClubName.Location = new System.Drawing.Point(839, 3);
            this.txtDisabledClubName.Name = "txtDisabledClubName";
            this.txtDisabledClubName.Size = new System.Drawing.Size(1106, 44);
            this.txtDisabledClubName.TabIndex = 26;
            // 
            // UpdateClubsDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(2651, 1505);
            this.Controls.Add(this.btnUpdateClubDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "UpdateClubsDescription";
            this.Text = "Update Description";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateClubsDescription_FormClosing);
            this.Load += new System.EventHandler(this.UpdateClubsDescription_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateClubDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtClubDesc;
        private System.Windows.Forms.TextBox txtDisabledClubName;
    }
}