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
    public partial class RegisterDeactiveClub : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        Controller cntrl = new Controller();
        public RegisterDeactiveClub()
        {
            InitializeComponent();
        }

        private void RegisterDeactiveClub_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            cntrl.DisplayDeactiveClubs();
        }

        private void RegisterDeactiveClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.RegisterDeactiveChil = null;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbDeactiveclubs.SelectedItem == null)
            {
                cmbDeactiveclubs.Items.Insert(0, "-Select");
                cmbDeactiveclubs.SelectedIndex = 0;
                MessageBox.Show("Something went wrong, please check if an item is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                    int statusDeactive = 0;
                    statusDeactive = cntrl.ActivateDeregClub(cmbDeactiveclubs.SelectedItem.ToString());
                    if (statusDeactive >= 1)
                    {
                        MessageBox.Show("Registered Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, please check if an item is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }

        }

        private void cmbDeactiveclubs_Click(object sender, EventArgs e)
        {
            if (cmbDeactiveclubs.Items.Count == 0)
            {
                MessageBox.Show("No Deactive Clubs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cntrl.DisplayDeactiveClubs();
            }
        }

        private void cmbDeactiveclubs_Enter(object sender, EventArgs e)
        {
            List<string> deactiveClubs = new List<String>();
            deactiveClubs = cntrl.DisplayDeactiveClubs();
            cmbDeactiveclubs.Items.Clear();
            cmbDeactiveclubs.Items.AddRange(deactiveClubs.Cast<Object>().ToArray());
            if (cmbDeactiveclubs.Items.Count == 0)
            {
                cmbDeactiveclubs.Items.Add("-Select");
                cmbDeactiveclubs.SelectedIndex = 0;
            }
        }

        private void cmbDeactiveclubs_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbDeactiveclubs.SelectedItem == null)
            {
                cmbDeactiveclubs.Items.Insert(0, "-Select");
                cmbDeactiveclubs.SelectedIndex = 0;
            }
        }
    }
}
