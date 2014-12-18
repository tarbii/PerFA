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
    class ViewTransactionCommand : ICommand
    {
        private readonly TransactionsClass transactions;

        public ViewTransactionCommand(TransactionsClass transactions)
        {
            this.transactions = transactions;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            transactions.TryLoadTransaction();
        }

        public event EventHandler CanExecuteChanged;
    }
}
