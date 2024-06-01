using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApi.Common
{
    public class LoginModel : BaseBinding
    {
        private string _username;
        private string _password;

        public string Username { get { return _username; } set { SetValue(ref _username , value); } }
        public string Password { get { return _password; } set { SetValue(ref _password , value); } }

    }
}
