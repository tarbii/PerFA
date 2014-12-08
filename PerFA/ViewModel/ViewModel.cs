using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class ViewModel
    {
        public Login Login { get; set; }

        public LoginCommand LoginCommand { get; set; }

        public ViewModel()
        {
            Login = new Login();
            LoginCommand = new LoginCommand(Login);
        }
    }
}
