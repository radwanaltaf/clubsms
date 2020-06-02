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

        public UpdateClub()
        {
            InitializeComponent();
        }

        private void UpdateClub_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cmbClub.SelectedIndex = 0;

        }

        private void UpdateClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.UpdateClubChild = null;
        }
    }
}
