using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clubs_Management_System
{
    public partial class Login : Form
    {
        User U = new User();
        Controller C = new Controller();

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

            U.emailProp = txtEmail.Text;
            U.passwordProp = txtPassword.Text;

            bool retVal = C.Login(U);

            if(retVal == true)
            {
                MessageBox.Show("Successfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
