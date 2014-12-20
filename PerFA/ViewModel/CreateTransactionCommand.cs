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
    class CreateTransactionCommand : ICommand
    {
        private readonly AllTransactionsClass allTransactionsClass;
        public CreateTransactionCommand(AllTransactionsClass allTransactionsClass)
        {
            this.allTransactionsClass = allTransactionsClass;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show(allTransactionsClass.SelectedNameOfTransaction);
        }

        public event EventHandler CanExecuteChanged;
    }
}
