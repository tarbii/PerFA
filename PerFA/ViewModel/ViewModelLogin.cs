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
        public Login Login { get; set; }

        public TransactionsClass TransactionsClass { get; set; }

        public LoginCommand LoginCommand { get; set; }

        public ViewModelLogin()
        {
            Login = new Login();
            TransactionsClass = new TransactionsClass(Login);
            LoginCommand = new LoginCommand(Login, this);
        }
    }
}
