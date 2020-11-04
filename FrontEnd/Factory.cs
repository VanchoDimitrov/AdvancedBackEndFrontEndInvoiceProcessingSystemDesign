using BackEnd;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrontEnd
{
    public class Factory
    {
        public static ILogin NewLogin() => new Login();

        //public static ILogin NewLogin()
        //{
        //    return new Login();
        //}

        public static ILoginDetails NewLoginDetails() => new LoginDetails();

        public static IFeature1 NewFEature1() => new Feature1();
    }
}
