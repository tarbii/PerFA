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
    class VMTransactionCommand : ICommand
    {
        private readonly TransactionsClass transactions;

        public VMTransactionCommand(TransactionsClass transactions)
        {
            this.transactions = transactions;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (transactions.SelectedTransaction != null)
            {
                MessageBox.Show(transactions.SelectedTransaction.Description);
            }
            else MessageBox.Show("No TransactionSelected");
        }

        public event EventHandler CanExecuteChanged;
    }
}
