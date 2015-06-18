using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassSave
{
    public class PasswordData
    {
        private string _username, _password, _website;
        public string Username
        {
            get { return _username; }
        }
        public string Password
        {
            get { return _password; }
        }
        public string Website
        {
            get { return _website; }
        }

        public PasswordData(string us, string pw, string wb = "")
        {
            _username = us;
            _password = pw;
            _website = wb;
        }
    }
}
