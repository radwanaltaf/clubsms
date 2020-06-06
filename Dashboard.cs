using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubs_Management_System
{
    public partial class Dashboard : Form
    {
        Controller Cntrl = new Controller();
        private Styling Styles = new Styling();
        private readonly DashboardScreens DBScreen = new DashboardScreens();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            menuStripMain.Items[0].Visible = false;
            menuStripMain.Items[1].Visible = false;
            menuStripMain.Items[2].Visible = false;
            menuStripMain.Items[3].Visible = false;
            menuStripMain.Items[4].Visible = false;
            menuStripMain.Items[5].Visible = false;
            menuStripMain.Items[6].Visible = false;
            menuStripMain.Items[7].Visible = false;

            if(role.UserRole == "admin")
            {
                Cntrl.DisplayMenuAdmin(updateClubDescItem: updateClubsDescriptionToolStripMenuItem,
                    updateClubActivity: updateClubsActivitiesToolStripMenuItem, 
                    searchItem: searchClubToolStripMenuItem,
                    registerItem: registerClubToolStripMenuItem,
                    deregisterItem: deregisterClubToolStripMenuItem,
                    updateClubItem: updateClubToolStripMenuItem,
                    clubReportItem: clubReportToolStripMenuItem,
                    activityReportItem: activitiesReportToolStripMenuItem);

                //Load & Display the Search Screen by default on App load
                if (DBScreen.SearchChild == null || DBScreen.SearchChild.IsDisposed)
                {
                    DBScreen.SearchChild = new SearchClubs();
                    DBScreen.SearchChild.MdiParent = this;
                }
                Styles.DashboardShowScreen(DBScreen.SearchChild);
            }
            else if(role.UserRole == "secretary")
            {
                Cntrl.DisplayMenuSecretary(updateClubDescItem: updateClubsDescriptionToolStripMenuItem, 
                    updateClubActivity: updateClubsActivitiesToolStripMenuItem,
                    searchItem: searchClubToolStripMenuItem,
                    registerItem: registerClubToolStripMenuItem,
                    deregisterItem: deregisterClubToolStripMenuItem,
                    updateClubItem: updateClubToolStripMenuItem,
                    clubReportItem: clubReportToolStripMenuItem,
                    activityReportItem: activitiesReportToolStripMenuItem);

                //Load & Display the Update Club Activity Screen by default on App load
                if (DBScreen.UpdateClubActivityChild == null || DBScreen.UpdateClubActivityChild.IsDisposed)
                {
                    DBScreen.UpdateClubActivityChild = new UpdateClubActivity();
                    DBScreen.UpdateClubActivityChild.MdiParent = this;
                }
                Styles.DashboardShowScreen(DBScreen.UpdateClubActivityChild);
            }
            else
            {
                Cntrl.DisplayMenuStudent(updateClubDescItem: updateClubsDescriptionToolStripMenuItem,
                    updateClubActivity: updateClubsActivitiesToolStripMenuItem,
                    searchItem: searchClubToolStripMenuItem,
                    registerItem: registerClubToolStripMenuItem,
                    deregisterItem: deregisterClubToolStripMenuItem,
                    updateClubItem: updateClubToolStripMenuItem,
                    clubReportItem: clubReportToolStripMenuItem,
                    activityReportItem: activitiesReportToolStripMenuItem);

                //Load & Display the Search Screen by default on App load
                if (DBScreen.SearchChild == null || DBScreen.SearchChild.IsDisposed)
                {
                    DBScreen.SearchChild = new SearchClubs();
                    DBScreen.SearchChild.MdiParent = this;
                }
                Styles.DashboardShowScreen(DBScreen.SearchChild);
            }
    
        }

        private void deregisterClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DBScreen.DeregisterChild == null || DBScreen.DeregisterChild.IsDisposed)
            {
                DBScreen.DeregisterChild = new DeregisterClub();
                DBScreen.DeregisterChild.MdiParent = this; 
            }
            Styles.DashboardShowScreen(DBScreen.DeregisterChild);

        }

        private void searchClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBScreen.SearchChild == null || DBScreen.SearchChild.IsDisposed)
            {
                DBScreen.SearchChild = new SearchClubs();
                DBScreen.SearchChild.MdiParent = this; 
            }
            Styles.DashboardShowScreen(DBScreen.SearchChild);
        }

        private void updateClubsDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBScreen.UpdateClubDescChild == null || DBScreen.UpdateClubDescChild.IsDisposed)
            {
                DBScreen.UpdateClubDescChild = new UpdateClubsDescription();
                DBScreen.UpdateClubDescChild.MdiParent = this; 
            }
            Styles.DashboardShowScreen(DBScreen.UpdateClubDescChild);
        }

        private void clubReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBScreen.ClubsReportChild == null || DBScreen.ClubsReportChild.IsDisposed)
            {
                DBScreen.ClubsReportChild = new ClubsReport();
                DBScreen.ClubsReportChild.MdiParent = this;
            }
            Styles.DashboardShowScreen(DBScreen.ClubsReportChild);
        }

        private void registerClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBScreen.RegisterChild == null || DBScreen.RegisterChild.IsDisposed)
            {
                DBScreen.RegisterChild = new RegisterClub();
                DBScreen.RegisterChild.MdiParent = this;
            }
            Styles.DashboardShowScreen(DBScreen.RegisterChild);
        }

        private void updateClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBScreen.UpdateClubChild == null || DBScreen.UpdateClubChild.IsDisposed)
            {
                DBScreen.UpdateClubChild = new UpdateClub();
                DBScreen.UpdateClubChild.MdiParent = this;
            }
            Styles.DashboardShowScreen(DBScreen.UpdateClubChild);

        }

        private void activitiesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBScreen.ReportActivitiesChild == null || DBScreen.ReportActivitiesChild.IsDisposed)
            {
                DBScreen.ReportActivitiesChild = new ReportActivities();
                DBScreen.ReportActivitiesChild.MdiParent = this;
            }
            Styles.DashboardShowScreen(DBScreen.ReportActivitiesChild);
        }

        private void updateClubsActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBScreen.UpdateClubActivityChild == null || DBScreen.UpdateClubActivityChild.IsDisposed)
            {
                DBScreen.UpdateClubActivityChild = new UpdateClubActivity();
                DBScreen.UpdateClubActivityChild.MdiParent = this;
            }
            Styles.DashboardShowScreen(DBScreen.UpdateClubActivityChild);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginn = new Login();
            loginn.Show();
            loginn.Focus();
        }
    }
}