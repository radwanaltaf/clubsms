namespace Clubs_Management_System
{
    partial class UpdateClubActivity
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
            this.txtClubAct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOfActivity = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateClubActivity = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAchiever = new System.Windows.Forms.TextBox();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2681, 198);
            this.label3.TabIndex = 14;
            this.label3.Text = "Update Club Activity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtClubAct
            // 
            this.txtClubAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubAct.ForeColor = System.Drawing.Color.Silver;
            this.txtClubAct.Location = new System.Drawing.Point(592, 676);
            this.txtClubAct.Multiline = true;
            this.txtClubAct.Name = "txtClubAct";
            this.txtClubAct.Size = new System.Drawing.Size(1044, 161);
            this.txtClubAct.TabIndex = 29;
            this.txtClubAct.Text = "Update Club Activity";
            this.txtClubAct.Enter += new System.EventHandler(this.txtClubAct_Enter);
            this.txtClubAct.Leave += new System.EventHandler(this.txtClubAct_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 49);
            this.label1.TabIndex = 16;
            this.label1.Text = "Activity Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 49);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date of Activity:";
            // 
            // dateOfActivity
            // 
            this.dateOfActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfActivity.Location = new System.Drawing.Point(592, 3);
            this.dateOfActivity.Name = "dateOfActivity";
            this.dateOfActivity.Size = new System.Drawing.Size(1044, 44);
            this.dateOfActivity.TabIndex = 26;
            // 
            // btnUpdateClubActivity
            // 
            this.btnUpdateClubActivity.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateClubActivity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateClubActivity.FlatAppearance.BorderSize = 0;
            this.btnUpdateClubActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClubActivity.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClubActivity.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdateClubActivity.Location = new System.Drawing.Point(0, 1150);
            this.btnUpdateClubActivity.Name = "btnUpdateClubActivity";
            this.btnUpdateClubActivity.Size = new System.Drawing.Size(2681, 245);
            this.btnUpdateClubActivity.TabIndex = 30;
            this.btnUpdateClubActivity.Text = "Click Here or Hit Enter To Update Club Activity";
            this.btnUpdateClubActivity.UseVisualStyleBackColor = false;
            this.btnUpdateClubActivity.Click += new System.EventHandler(this.btnUpdateClubActivity_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.93655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.06345F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAchiever, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtActivityName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtClubAct, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateOfActivity, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(470, 290);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.36247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.41902F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.21851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1639, 845);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 49);
            this.label6.TabIndex = 26;
            this.label6.Text = "Achiever\'s Name:";
            // 
            // txtAchiever
            // 
            this.txtAchiever.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchiever.ForeColor = System.Drawing.Color.Silver;
            this.txtAchiever.Location = new System.Drawing.Point(593, 440);
            this.txtAchiever.Margin = new System.Windows.Forms.Padding(4);
            this.txtAchiever.MaxLength = 75;
            this.txtAchiever.Name = "txtAchiever";
            this.txtAchiever.Size = new System.Drawing.Size(1042, 44);
            this.txtAchiever.TabIndex = 28;
            this.txtAchiever.Text = "Enter Achiever\'s Name";
            this.txtAchiever.Enter += new System.EventHandler(this.txtAchiever_Enter);
            this.txtAchiever.Leave += new System.EventHandler(this.txtAchiever_Leave);
            // 
            // txtActivityName
            // 
            this.txtActivityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityName.ForeColor = System.Drawing.Color.Silver;
            this.txtActivityName.Location = new System.Drawing.Point(593, 215);
            this.txtActivityName.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivityName.MaxLength = 75;
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(1042, 44);
            this.txtActivityName.TabIndex = 27;
            this.txtActivityName.Text = "Enter Activity\'s Name";
            this.txtActivityName.Enter += new System.EventHandler(this.txtActivityName_Enter);
            this.txtActivityName.Leave += new System.EventHandler(this.txtActivityName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 49);
            this.label5.TabIndex = 26;
            this.label5.Text = "Activity\'s Name:";
            // 
            // UpdateClubActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(2681, 1395);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnUpdateClubActivity);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "UpdateClubActivity";
            this.Text = "Update Club Activity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateClubActivity_FormClosing);
            this.Load += new System.EventHandler(this.UpdateClubActivity_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClubAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateOfActivity;
        private System.Windows.Forms.Button btnUpdateClubActivity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.TextBox txtAchiever;
        private System.Windows.Forms.Label label6;
    }
}