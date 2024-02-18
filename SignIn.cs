using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeAppNew
{
    public class SignIn
    {
        public string Authenticate(string userName, string password)
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string msg;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            if ((string.IsNullOrEmpty(userName)) || string.IsNullOrEmpty(password))
            {
                msg = "User name and password required";
            }
            else
            {
                if ((userName == "admin") && (password == "admin@1256"))
                {
                    msg = "Authenticate pass";
                }
                else
                {
                    msg = "Authenticate fail";
                }

            }
            return "Provide user details";
        }
    }

}


