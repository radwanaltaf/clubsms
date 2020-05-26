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
        private string _firstName;
        private string _lastname;
        private string _role;

        public string emailProp
        {
            get { return _emailID; }
            set { _emailID = value; }
        }

        public string passwordProp
        {
            get { return _pswd; }
            set { _pswd = value; }
        }

        public string firstNameProp
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string lastNameProp
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string roleProp
        {
            get { return _role; }
            set { _role = value; }
        }


    }
}
