using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAPP
{
    internal interface IAuthenticator
    {
        void Register(string username, string password);
        bool Login(string username, string password);
        bool ConfirmPassword(string password1, string password2);
    }
}
