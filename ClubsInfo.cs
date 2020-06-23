using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubs_Management_System
{
    class ClubsInfo
    {
        private static string _clubname;
        private static string _pname;
        private static string _vpname;
        private static string _secname;
        private static string _clubdesc;

        public static string ClubName { get => _clubname; set => _clubname = value; }
        public static string PName { get => _pname; set => _pname = value; }
        public static string VPName { get => _vpname; set => _vpname = value; }
        public static string SecName { get => _secname; set => _secname = value; }
        public static string ClubDesc { get => _clubdesc; set => _clubdesc = value; }
    }
}