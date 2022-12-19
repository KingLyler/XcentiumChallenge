using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcentiumChallenge
{
    internal class LoggedInUser
    {
        static int _id;
        static string _username;
        static string _name;
        static string _password;

        public static int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string Name
        {
            get { return _name; } 
            set { _name = value; }
        }
        
        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
