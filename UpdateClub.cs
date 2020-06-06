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
    public partial class UpdateClub : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        Controller cntrl = new Controller();
        public UpdateClub()
        {
            InitializeComponent();
        }

        private void UpdateClubs_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cmbClub.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClub.SelectedIndex = 0;
            List<string> allClubs = cntrl.DisplayAllClubs();
            cmbClub.Items.AddRange(allClubs.Cast<Object>().ToArray());

            if (cmbClub.SelectedItem.ToString() == "-Select Club")
            {
                txtClubName.Text = "Enter Club's Name";
                txtPresName.Text = "Enter President's Name";
                txtVpName.Text = "Enter Vice President's Name";
                txtSecName.Text = "Enter Secretary's Name";
                txtRegClubDesc.Text = "Enter Club's Description";

                txtClubName.ForeColor = Color.Silver;
                txtPresName.ForeColor = Color.Silver;
                txtVpName.ForeColor = Color.Silver;
                txtSecName.ForeColor = Color.Silver;
                txtRegClubDesc.ForeColor = Color.Silver;
            }
        }

        private void btnUpdateClubAdmin_Click(object sender, EventArgs e)
        {
            if (cmbClub.SelectedItem.ToString() == "-Select Club"
               || string.IsNullOrWhiteSpace(txtClubName.Text) || txtClubName.Text == "Enter Club's Name"
               || string.IsNullOrWhiteSpace(txtPresName.Text) || txtPresName.Text == "Enter President's Name"
               || string.IsNullOrWhiteSpace(txtVpName.Text) || txtVpName.Text == "Enter Vice President's Name"
               || string.IsNullOrWhiteSpace(txtSecName.Text) || txtSecName.Text == "Enter Secretary's Name"
               || string.IsNullOrWhiteSpace(txtRegClubDesc.Text) || txtRegClubDesc.Text == "Enter Club's Description")
            {
                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int status = 0;
                status = cntrl.UpdateClub(txtClubName.Text, txtPresName.Text, txtVpName.Text, txtSecName.Text, txtRegClubDesc.Text, cmbClub.SelectedItem.ToString());

                if (status >= 1)
                {
                    MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbClub.Items.Clear();
                    List<string> allClubs = new List<string>();
                    allClubs = cntrl.DisplayAllClubs();
                    cmbClub.Items.AddRange(allClubs.Cast<Object>().ToArray());
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtClubName_Enter(object sender, EventArgs e)
        {
            if (txtClubName.Text == "Enter Club's Name")
            {
                txtClubName.Text = "";
                txtClubName.ForeColor = Color.Black;
            }
        }

        private void txtClubName_Leave(object sender, EventArgs e)
        {
            if (txtClubName.Text == "")
            {
                txtClubName.Text = "Enter Club's Name";
                txtClubName.ForeColor = Color.Silver;
            }
        }

        private void txtPresName_Leave(object sender, EventArgs e)
        {
            if (txtPresName.Text == "")
            {
                txtPresName.Text = "Enter President's Name";
                txtPresName.ForeColor = Color.Silver;
            }
        }

        private void txtPresName_Enter(object sender, EventArgs e)
        {
            if (txtPresName.Text == "Enter President's Name")
            {
                txtPresName.Text = "";
                txtPresName.ForeColor = Color.Black;
            }
        }

        private void txtVpName_Enter(object sender, EventArgs e)
        {
            if (txtVpName.Text == "Enter Vice President's Name")
            {
                txtVpName.Text = "";
                txtVpName.ForeColor = Color.Black;
            }
        }

        private void txtVpName_Leave(object sender, EventArgs e)
        {
            if (txtVpName.Text == "")
            {
                txtVpName.Text = "Enter Vice President's Name";
                txtVpName.ForeColor = Color.Silver;
            }
        }

        private void txtSecName_Enter(object sender, EventArgs e)
        {
            if (txtSecName.Text == "Enter Secretary's Name")
            {
                txtSecName.Text = "";
                txtSecName.ForeColor = Color.Black;
            }
        }

        private void txtSecName_Leave(object sender, EventArgs e)
        {
            if (txtSecName.Text == "")
            {
                txtSecName.Text = "Enter Secretary's Name";
                txtSecName.ForeColor = Color.Silver;
            }
        }

        private void txtRegClubDesc_Enter(object sender, EventArgs e)
        {
            if (txtRegClubDesc.Text == "Enter Club's Description")
            {
                txtRegClubDesc.Text = "";
                txtRegClubDesc.ForeColor = Color.Black;
            }
        }

        private void txtRegClubDesc_Leave(object sender, EventArgs e)
        {
            if (txtRegClubDesc.Text == "")
            {
                txtRegClubDesc.Text = "Enter Club's Description";
                txtRegClubDesc.ForeColor = Color.Silver;
            }
        }

        private void cmbClub_Enter(object sender, EventArgs e)
        {
            cmbClub.ForeColor = Color.Black;
        }

        private void cmbClub_Leave(object sender, EventArgs e)
        {
            if (cmbClub.SelectedItem.ToString() == "-Select Club")
            {
                cmbClub.ForeColor = Color.Silver;
            }
        }

        private void cmbClub_SelectedIndexChanged(object sender, EventArgs e)
        {

            cntrl.SearchClub(cmbClub.SelectedItem.ToString());
            txtClubName.Text = ClubsInfo.ClubName;
            txtPresName.Text = ClubsInfo.PName;
            txtVpName.Text = ClubsInfo.VPName;
            txtSecName.Text = ClubsInfo.SecName;
            txtRegClubDesc.Text = ClubsInfo.ClubDesc;

            txtClubName.ForeColor = Color.Black;
            txtPresName.ForeColor = Color.Black;
            txtVpName.ForeColor = Color.Black;
            txtSecName.ForeColor = Color.Black;
            txtRegClubDesc.ForeColor = Color.Black;

            if (cmbClub.SelectedIndex == 0)
            {
                txtClubName.Text = "Enter Club's Name";
                txtPresName.Text = "Enter President's Name";
                txtVpName.Text = "Enter Vice President's Name";
                txtSecName.Text = "Enter Secretary's Name";
                txtRegClubDesc.Text = "Enter Club's Description";

                txtClubName.ForeColor = Color.Silver;
                txtPresName.ForeColor = Color.Silver;
                txtVpName.ForeColor = Color.Silver;
                txtSecName.ForeColor = Color.Silver;
                txtRegClubDesc.ForeColor = Color.Silver;

                txtClubName.Enabled = false;
                txtPresName.Enabled = false;
                txtVpName.Enabled = false;
                txtSecName.Enabled = false;
                txtRegClubDesc.Enabled = false;
            }
            else
            {

                txtClubName.Enabled = true;
                txtPresName.Enabled = true;
                txtVpName.Enabled = true;
                txtSecName.Enabled = true;
                txtRegClubDesc.Enabled = true;
            }
        }
    }
}
