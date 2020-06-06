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
        private static byte[] _imgPath;
        public static string Username { get => _username; set => _username = value; }
        public static string ClubName { get => _clubname; set => _clubname = value; }
        public static byte[] ImgPath { get => _imgPath; set => _imgPath = value; }
    }
}
