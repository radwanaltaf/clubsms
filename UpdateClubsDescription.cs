using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubs_Management_System
{
    public partial class UpdateClubsDescription : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        Controller cntrl = new Controller();
        public UpdateClubsDescription()
        {
            InitializeComponent();
        }

        private void UpdateClubsDescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.UpdateClubDescChild = null;
        }

        private void UpdateClubsDescription_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            txtClubDesc.ForeColor = Color.Silver;
            txtDisabledClubName.Enabled = false;
            cntrl.LoggedInSecClub(LoggedInUser.Username);
            txtDisabledClubName.Text = LoggedInUser.ClubName;
        }

        private void txtClubDesc_Enter(object sender, EventArgs e)
        {
            if(txtClubDesc.Text == "Enter New Description")
            {
                txtClubDesc.Text = "";
                txtClubDesc.ForeColor = Color.Black;
            }
        }

        private void txtClubDesc_Leave(object sender, EventArgs e)
        {
            if (txtClubDesc.Text == "")
            {
                txtClubDesc.Text = "Enter New Description";
                txtClubDesc.ForeColor = Color.Silver;
            }
        }

        private void btnUpdateClubDesc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClubDesc.Text) || txtClubDesc.Text == "Enter New Description")
            {
                MessageBox.Show("Please type a new club description", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int status = 0;
                status = cntrl.UpdateClubsDesc(LoggedInUser.Username, txtClubDesc.Text);

                if (status > 0)
                {
                    MessageBox.Show("Club's Description Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
