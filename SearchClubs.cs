﻿using System;
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
    public partial class SearchClubs : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        Controller cntrl = new Controller();
        public SearchClubs()
        {
            InitializeComponent();
        }

        private void SearchClub_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cmbClubName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClubName.SelectedIndex = 0;
            List<string> allClubs = cntrl.DisplayAllClubs();
            cmbClubName.Items.AddRange(allClubs.Cast<Object>().ToArray());
        }

        private void SearchClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.SearchChild = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if(cmbClubName.SelectedItem.ToString() == "-Select Club")
            //{
            //    MessageBox.Show("Please Chose a Club", "No Club Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    lstClubInfo.Items.Clear();
            //    cntrl.SearchClub(cmbClubName.SelectedItem.ToString());
            //    lstClubInfo.Items.Add("Club's Name: \t\t" + ClubsInfo.ClubName);
            //    lstClubInfo.Items.Add("President's Name: \t\t" + ClubsInfo.PName);
            //    lstClubInfo.Items.Add("Vice President's Name: \t" + ClubsInfo.VPName);
            //    lstClubInfo.Items.Add("Secretary's Name: \t\t" + ClubsInfo.SecName);
            //    lstClubInfo.Items.Add("Club's Description: \t\t" + ClubsInfo.ClubDesc);
            //}

        }

        private void cmbClubName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClubName.SelectedItem.ToString() == "-Select Club")
            {
                lstClubInfo.Items.Clear();
            }
            else
            {
                lstClubInfo.Items.Clear();
                cntrl.SearchClub(cmbClubName.SelectedItem.ToString());
                lstClubInfo.Items.Add("Club's Name: \t\t" + ClubsInfo.ClubName);
                lstClubInfo.Items.Add("President's Name: \t\t" + ClubsInfo.PName);
                lstClubInfo.Items.Add("Vice President's Name: \t" + ClubsInfo.VPName);
                lstClubInfo.Items.Add("Secretary's Name: \t\t" + ClubsInfo.SecName);
                lstClubInfo.Items.Add("Club's Description: \t\t" + ClubsInfo.ClubDesc);
            }
        }
    }
}
