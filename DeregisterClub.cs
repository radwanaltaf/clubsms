using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubs_Management_System
{
    public partial class DeregisterClub : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        Controller cntrl = new Controller();
        public DeregisterClub()
        {
            InitializeComponent();
        }

        private void DeregisterClub_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox= false;
            this.ControlBox = false;
            cmbClubName.SelectedIndex = 0;
            pickerDeregisterationDate.MinDate = DateTime.Today;
            pickerDeregisterationDate.MaxDate = DateTime.Today.AddDays(14);
            cntrl.DisplayAllClubs();
            List<string> allClubs = cntrl.DisplayAllClubs();
            cmbClubName.Items.AddRange(allClubs.Cast<Object>().ToArray());
            this.BackColor = Color.FromArgb(62, 120, 138);
        }

        private void btnDeregisterClub_Click(object sender, EventArgs e)
        {
            int status = 0;
            status = cntrl.DeRegisterClub(cmbClubName.SelectedItem.ToString(), pickerDeregisterationDate.Value);
            if (status >= 1)
            {
                MessageBox.Show("The club was deactivated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbClubName.Items.Remove(cmbClubName.SelectedItem);
            }
            else
            {
                MessageBox.Show("Error", "Error Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeregisterClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.DeregisterChild = null;
        }
    }
}
