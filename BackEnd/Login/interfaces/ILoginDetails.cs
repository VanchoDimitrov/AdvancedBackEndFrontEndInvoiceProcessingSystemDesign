using System.Collections.Generic;

namespace BackEnd
{
    public interface ILoginDetails
    {
        List<Login> LoginList { get; set; }

        bool GetLoginInfo(string u, string p);
        List<Login> GetUsers();
    }
}