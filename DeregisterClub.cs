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
    public partial class DeregisterClub : Form
    {
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


    }
}