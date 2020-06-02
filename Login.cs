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
    public partial class Login : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        User Usr = new User();
        Controller Cntrl = new Controller();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmail.Select(); // Select the Email text box at the time of form load.
            cmbSelectRole.SelectedIndex = 0; // Select the firs item of the combo box at form load. 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usr.emailProp = txtEmail.Text;
            Usr.passwordProp = txtPassword.Text;
            Usr.roleProp = cmbSelectRole.SelectedItem.ToString();

            bool retVal = Cntrl.Login(Usr);

            if (retVal == true)
            {
                Dashboard D = new Dashboard();
                D.Show();
                D.Focus();
                MessageBox.Show("Welcome " + User.firstNameProp, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.LoginChild = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
