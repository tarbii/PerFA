using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class ViewModelTransactions
    {
        public ViewTransactionCommand ViewTransactionCommand { get; set; }

        public TransactionsClass TransactionsClass { get; set; }

        public ViewModelTransactions()
        {
            TransactionsClass = new TransactionsClass();
            ViewTransactionCommand = new ViewTransactionCommand(TransactionsClass);
        }

        public void LoadTransactions(int userId)
        {
            TransactionsClass.LoadTransactions(userId);
        }
    }
}
