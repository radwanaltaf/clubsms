using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubs_Management_System
{
    class ControlMenuBar
    {
        //A method which will Hide & Show the menu items for the Admin
        public void DisplayMenuAdmin(ToolStripMenuItem searchItem, ToolStripMenuItem registerItem, ToolStripMenuItem deregisterItem, ToolStripMenuItem updateClubItem, ToolStripMenuItem clubReportItem, ToolStripMenuItem activityReportItem, ToolStripMenuItem updateClubDescItem, ToolStripMenuItem updateClubActivity, ToolStripMenuItem RegDeactiveclub)
        {
            updateClubDescItem.Visible = false;
            updateClubActivity.Visible = false;
            searchItem.Visible = true;
            registerItem.Visible = true;
            deregisterItem.Visible = true;
            updateClubItem.Visible = true;
            clubReportItem.Visible = true;
            activityReportItem.Visible = true;
            RegDeactiveclub.Visible = true;
        }

        //A method which will Hide & Show the menu items for the Secretary
        public void DisplayMenuSecretary(ToolStripMenuItem searchItem, ToolStripMenuItem registerItem, ToolStripMenuItem deregisterItem, ToolStripMenuItem updateClubItem, ToolStripMenuItem clubReportItem, ToolStripMenuItem activityReportItem, ToolStripMenuItem updateClubDescItem, ToolStripMenuItem updateClubActivity, ToolStripMenuItem RegDeactiveclub)
        {
            updateClubDescItem.Visible = true;
            updateClubActivity.Visible = true;
            searchItem.Visible = false;
            registerItem.Visible = false;
            deregisterItem.Visible = false;
            updateClubItem.Visible = false;
            clubReportItem.Visible = false;
            activityReportItem.Visible = false;
            RegDeactiveclub.Visible = false;
        }

        //A method which will Hide & Show the menu items for the student
        public void DisplayMenuStudent(ToolStripMenuItem searchItem, ToolStripMenuItem registerItem, ToolStripMenuItem deregisterItem, ToolStripMenuItem updateClubItem, ToolStripMenuItem clubReportItem, ToolStripMenuItem activityReportItem, ToolStripMenuItem updateClubDescItem, ToolStripMenuItem updateClubActivity, ToolStripMenuItem RegDeactiveclub)
        {
            updateClubDescItem.Visible = false;
            updateClubActivity.Visible = false;
            searchItem.Visible = true;
            registerItem.Visible = false;
            deregisterItem.Visible = false;
            updateClubItem.Visible = false;
            clubReportItem.Visible = false;
            activityReportItem.Visible = false;
            RegDeactiveclub.Visible = false;
        }
    }
}
