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

        public SearchClubs()
        {
            InitializeComponent();
        }

        private void SearchClubs_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void SearchClubs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.SearchChild = null;
        }
    }
}
