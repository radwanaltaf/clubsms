using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubs_Management_System
{
    public partial class UpdateClubActivity : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        Controller cntrl = new Controller();
        public UpdateClubActivity()
        {
            InitializeComponent();
        }

        private void UpdateClubActivity_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            dateOfActivity.MinDate = DateTime.Today;
            dateOfActivity.MaxDate = DateTime.Today.AddDays(30);
            cntrl.LoggedInSecClub(LoggedInUser.Username);
        }

        private void UpdateClubActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.UpdateClubActivityChild = null;
        }

        private void btnUpdateClubActivity_Click(object sender, EventArgs e)
        {
            bool activityExistss = false;
            int status = 0;
            if (string.IsNullOrWhiteSpace(txtAchiever.Text) || txtAchiever.Text == "Enter Achiever's Name"
                || string.IsNullOrWhiteSpace(txtActivityName.Text) || txtActivityName.Text == "Enter Activity's Name"
                || string.IsNullOrWhiteSpace(txtClubAct.Text) || txtClubAct.Text == "Update Club Description")
            {
                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                activityExistss = cntrl.CheckActivityExists(LoggedInUser.ClubName, txtActivityName.Text);
                if (activityExistss == true)
                {
                    MessageBox.Show("The activity already exists, if it is not a duplicate please enter the activity name with 2nd at the end", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    status = cntrl.UpdateClubActivity(LoggedInUser.ClubName, txtActivityName.Text, txtAchiever.Text, dateOfActivity.Value.ToString(), txtClubAct.Text);
            
                    if(status > 0)
                    {
                        MessageBox.Show("Activity Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, please try again", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void txtAchiever_Enter(object sender, EventArgs e)
        {
            if(txtAchiever.Text == "Enter Achiever's Name")
            {
                txtAchiever.Text = "";
                txtAchiever.ForeColor = Color.Black;
            }
        }

        private void txtAchiever_Leave(object sender, EventArgs e)
        {
            if (txtAchiever.Text == "")
            {
                txtAchiever.Text = "Enter Achiever's Name";
                txtAchiever.ForeColor = Color.Silver;
            }
        }

        private void txtActivityName_Enter(object sender, EventArgs e)
        {
            if (txtActivityName.Text == "Enter Activity's Name")
            {
                txtActivityName.Text = "";
                txtActivityName.ForeColor = Color.Black;
            }
        }

        private void txtActivityName_Leave(object sender, EventArgs e)
        {
            if (txtActivityName.Text == "")
            {
                txtActivityName.Text = "Enter Activity's Name";
                txtActivityName.ForeColor = Color.Silver;
            }
        }

        private void txtClubAct_Enter(object sender, EventArgs e)
        {
            if (txtClubAct.Text == "Update Club Activity")
            {
                txtClubAct.Text = "";
                txtClubAct.ForeColor = Color.Black;
            }
        }

        private void txtClubAct_Leave(object sender, EventArgs e)
        {
            if (txtClubAct.Text == "")
            {
                txtClubAct.Text = "Update Club Activity";
                txtClubAct.ForeColor = Color.Silver;
            }
        }
    }
}
