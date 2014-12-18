using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class VMLogin
    {
        public Action<int> CreateAllTransactionsWindowAction { get; set; }

        public Login Login { get; set; }

        public LoginCommand LoginCommand { get; set; }

        public VMLogin()
        {
            Login = new Login();
            Login.LoginSucceed += Login_LoginSucceed;
            LoginCommand = new LoginCommand(Login);
        }

        private void Login_LoginSucceed(int userId)
        {
            CreateAllTransactionsWindowAction(userId);
        }
    }
}
