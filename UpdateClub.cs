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
                    MessageBox.Show("Record Updated Successfully", "Success2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Error Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
