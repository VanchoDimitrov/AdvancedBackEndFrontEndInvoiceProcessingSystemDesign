using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Login : ILogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Login(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        public Login()
        {

        }
    }
}
