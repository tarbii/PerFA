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
        public VMTransactionCommand ViewTransactionCommand { get; set; }

        public TransactionsClass TransactionsClass { get; set; }

        public VMAllTransactions()
        {
            TransactionsClass = new TransactionsClass();
            ViewTransactionCommand = new VMTransactionCommand(TransactionsClass);
        }

        public void LoadTransactions(int userId)
        {
            TransactionsClass.LoadTransactions(userId);
        }
    }
}
