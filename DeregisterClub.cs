using System;
using System.Windows.Forms;

namespace Clubs_Management_System
{
    public partial class DeregisterClub : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        public DeregisterClub()
        {
            InitializeComponent();
        }

        private void DeregisterClub_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cmbClubName.SelectedIndex = 0;
        }

        private void btnDeregisterClub_Click(object sender, EventArgs e)
        {

        }

        private void DeregisterClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.DeregisterChild = null;
        }
    }
}
