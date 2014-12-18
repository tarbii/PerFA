using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using PerFA.Model;
using PerFA.View;

namespace PerFA.ViewModel
{
    class LoginCommand : ICommand
    {
        private readonly Login login;

        public LoginCommand(Login login)
        {
            this.login = login;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            login.TryLogin();
        }

        public event EventHandler CanExecuteChanged;
    }
}
