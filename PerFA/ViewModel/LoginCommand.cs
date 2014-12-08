using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class LoginCommand : ICommand
    {
        private readonly Login login;

        public LoginCommand(Login example)
        {
            this.login = example;
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
