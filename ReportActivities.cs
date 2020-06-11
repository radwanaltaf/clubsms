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
    public partial class ReportActivities : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();

        public ReportActivities()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsClubs.ClubActivities' table. You can move, or remove it, as needed.
            this.ClubActivitiesTableAdapter.Fill(this.dsClubs.ClubActivities);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.reportViewer1.RefreshReport();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.ReportActivitiesChild = null;
        }
    }
}
