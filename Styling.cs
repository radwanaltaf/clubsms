using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubs_Management_System
{
    class Styling
    {
        public void DashboardShowScreen(Form screenName)
        {
            screenName.Dock = DockStyle.Fill;
            screenName.Show();
            screenName.Focus();
        }
    }
}
