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

        private void UpdateClub_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cmbClub.SelectedIndex = 0;
            List<string> acc = cntrl.DisplayAllClubs();
            cmbClub.Items.AddRange(acc.Cast<Object>().ToArray());
        }

        private void UpdateClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.UpdateClubChild = null;
        }
    }
}
