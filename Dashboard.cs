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
    public partial class Dashboard : Form
    {
        DeregisterClub formChildDeregister;
        SearchClubs formChildSearchStudent;
        UpdateClubsDescription formChildUpdateClubDesc;
        ClubsReport formChildClubsReport;
        RegisterClub formChildRegisterClub;
        UpdateClub formChildUpdateClub;
        ReportActivities formChildActivitiesReport;
        UpdateClubActivity formChildUpdateClubActivity;
        Login formChildLogin;
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void deregisterClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChildDeregister = new DeregisterClub();            
            formChildDeregister.MdiParent = this; //the frmchild is refering to the Register_Club and MdiParent is holding the frmChild to (this) Dashboard
            formChildDeregister.Dock = DockStyle.Fill;
            formChildDeregister.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

//            menuStripMain.Items[1].Visible = false;
//            menuStripMain.Items[2].Visible = false;
//            menuStripMain.Items[3].Visible = false;
//            menuStripMain.Items[4].Visible = false;
//            menuStripMain.Items[5].Visible = false;
//            menuStripMain.Items[6].Visible = false;
//            menuStripMain.Items[7].Visible = false;
//            menuStripMain.Items[8].Visible = false;

            formChildLogin = new Login();
            formChildLogin.MdiParent = this;
            formChildLogin.Dock = DockStyle.Fill;
            formChildLogin.Show();


        }

        private void searchClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChildSearchStudent = new SearchClubs();
            formChildSearchStudent.MdiParent = this;
            formChildSearchStudent.Dock = DockStyle.Fill;
            formChildSearchStudent.Show();
        }

        private void updateClubsDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChildUpdateClubDesc = new UpdateClubsDescription();
            formChildUpdateClubDesc.MdiParent = this;
            formChildUpdateClubDesc.Dock = DockStyle.Fill;
            formChildUpdateClubDesc.Show();
        }

        private void clubReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChildClubsReport = new ClubsReport();
            formChildClubsReport.MdiParent = this;
            formChildClubsReport.Dock = DockStyle.Fill;
            formChildClubsReport.Show();
        }

        private void registerClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChildRegisterClub = new RegisterClub();
            formChildRegisterClub.MdiParent = this;
            formChildRegisterClub.Dock = DockStyle.Fill;
            formChildRegisterClub.Show();
        }

        private void updateClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChildUpdateClub = new UpdateClub();
            formChildUpdateClub.MdiParent = this;
            formChildUpdateClub.Dock = DockStyle.Fill;
            formChildUpdateClub.Show();
        }

        private void activitiesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChildActivitiesReport = new ReportActivities();
            formChildActivitiesReport.MdiParent = this;
            formChildActivitiesReport.Dock = DockStyle.Fill;
            formChildActivitiesReport.Show();
        }

        private void updateClubsActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChildUpdateClubActivity = new UpdateClubActivity();
            formChildUpdateClubActivity.MdiParent = this;
            formChildUpdateClubActivity.Dock = DockStyle.Fill;
            formChildUpdateClubActivity.Show();
        }

        private void menuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            formChildLogin = new Login();
            formChildLogin.MdiParent = this;
            formChildLogin.Dock = DockStyle.Fill;
            formChildLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}