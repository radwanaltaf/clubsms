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
    public partial class UpdateClubsDescription : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        public UpdateClubsDescription()
        {
            InitializeComponent();
        }

        private void UpdateClubsDescription_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void UpdateClubsDescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.UpdateClubDescChild = null;
        }
    }
}