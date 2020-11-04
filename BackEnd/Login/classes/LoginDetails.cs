using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace BackEnd
{
    public class LoginDetails : ILoginDetails
    {
        public List<Login> LoginList { get; set; } = new List<Login>();

        /// <summary>
        /// Returns all users
        /// </summary>
        /// <returns></returns>
        public List<Login> GetUsers()
        {
            return DefaultLoginData();
        }

        /// <summary>
        /// Feeds the collection LoginList with dafult data.
        /// </summary>
        /// <returns></returns>
        protected List<Login> DefaultLoginData()
        {
            LoginList = new List<Login>()
            {
                new Login{ UserName="a", Password="a"},
                new Login{ UserName="b", Password="b"},
                new Login{ UserName="c", Password="c"},
            };

            return LoginList;
        }

        /// <summary>
        /// Check if supplied UserName and Password exists. If yes, login if not can't login
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool GetLoginInfo(string u, string p)
        {
            return Logged(u, p);
        }

        /// <summary>
        ///  Check if user is logged?
        /// </summary>
        /// <returns></returns>
        protected bool Logged(string userName, string password)
        {
            GetUsers();

            foreach (var i in LoginList)
            {
                if (string.Equals(userName, i.UserName) && string.Equals(password, i.Password))
                    return true;
                else
                    return false;
            }

            return false;
        }
    }
}
