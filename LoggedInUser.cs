using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubs_Management_System
{
    static class LoggedInUser
    {
        private static string _username;
        private static string _clubname;
        public static string Username { get => _username; set => _username = value; }
        public static string ClubName { get => _clubname; set => _clubname = value; }
    }
}
