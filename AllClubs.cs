using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubs_Management_System
{
    class AllClubs
    {
        private static List<string> _Clubs = new List<string>();
        public static List<string> Clubs { get => _Clubs; set => _Clubs = value; }
    }
}