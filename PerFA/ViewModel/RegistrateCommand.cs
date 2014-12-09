using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class RegistrateCommand : ICommand
    {
        private Registration registration;

        public RegistrateCommand(Registration registration)
        {
            this.registration = registration;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            registration.Registrate();
        }

        public event EventHandler CanExecuteChanged;
    }
}
