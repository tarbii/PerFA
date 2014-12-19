using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PerFA.Model;

namespace PerFA.View
{
    class SaveChangesCommand : ICommand
    {
        private TransactionClass transaction;
        
        public SaveChangesCommand(TransactionClass transaction)
        {
            this.transaction = transaction;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            transaction.SaveChanges();
        }

        public event EventHandler CanExecuteChanged;
    }
}
