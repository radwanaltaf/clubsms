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
    public partial class UpdateClubActivity : Form
    {
        DashboardScreens DBScreen = new DashboardScreens();
        public UpdateClubActivity()
        {
            InitializeComponent();
        }

        private void UpdateClubActivity_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        private void UpdateClubActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBScreen.UpdateClubActivityChild = null;
        }

        private void btnUploadPics_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Image| *.png|JPEG| *.JPEG|JPG| *.JPG";
            ofd.Title = "Open an image";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbxEvent.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
