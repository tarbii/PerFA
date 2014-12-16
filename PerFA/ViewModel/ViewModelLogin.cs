using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class ViewModelLogin
    {
        public Action<Login> CreateTransactionWindowAction { get; set; }

        public Login Login { get; set; }

        public LoginCommand LoginCommand { get; set; }

        public ViewModelLogin()
        {
            Login = new Login();
            LoginCommand = new LoginCommand(Login, this);
        }
    }
}
