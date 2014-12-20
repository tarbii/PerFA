using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class DeleteTransactionCommand : ICommand
    {
        private readonly AllTransactionsClass allTransactionsClass;

        public DeleteTransactionCommand(AllTransactionsClass allTransactionsClass)
        {
            this.allTransactionsClass = allTransactionsClass;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            allTransactionsClass.DeleteTransaction();
        }

        public event EventHandler CanExecuteChanged;
    }
}
