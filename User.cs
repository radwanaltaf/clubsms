using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubs_Management_System
{
    class User
    {
        private string _emailID;
        private string _pswd;
        private static string _firstName;
        private static string _lastname;
        private string _role;

        public string emailProp { get => _emailID; set => _emailID = value; }
        public string passwordProp { get => _pswd; set => _pswd = value; }
        public static string firstNameProp { get => _firstName; set => _firstName = value; }
        public static string lastNameProp { get => _lastname; set => _lastname = value; }
        public string roleProp { get => _role; set => _role = value; }
    }
}
