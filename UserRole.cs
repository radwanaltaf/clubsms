using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubs_Management_System
{
    //A static class with static properties in order to access the retrieved UserRole from all screens
    static class role
    {
        private static string _UserRole = "";
        public static string UserRole { get => _UserRole; set => _UserRole = value; }
    }
}
