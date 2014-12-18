using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class VMAllTransactions
    {
        public Action<int, int> CreateTransactionWindowAction { get; set; }

        public ViewTransactionCommand VMTransactionCommand { get; set; }

        public TransactionsClass TransactionsClass { get; set; }

        public VMAllTransactions()
        {
            TransactionsClass = new TransactionsClass();
            VMTransactionCommand = new ViewTransactionCommand(TransactionsClass);
        }

        public void LoadTransactions(int userId)
        {
            TransactionsClass.LoadTransactions(userId);
        }
    }
}
