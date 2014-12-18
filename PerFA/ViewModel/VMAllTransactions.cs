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
        public Action<string> ShowMessageBoxAction { get; set; }

        public ViewTransactionCommand VMTransactionCommand { get; set; }

        public AllTransactionsClass TransactionsClass { get; set; }

        public VMAllTransactions()
        {
            TransactionsClass = new AllTransactionsClass();
            TransactionsClass.TransactionLoadSucceed += 
                TransactionsClass_TransactionLoadSucceed;
            TransactionsClass.TransactionLoadFailed += TransactionsClass_TransactionLoadFailed;
            VMTransactionCommand = new ViewTransactionCommand(TransactionsClass);
        }

        void TransactionsClass_TransactionLoadFailed(string message)
        {
            ShowMessageBoxAction(message);
        }

        void TransactionsClass_TransactionLoadSucceed(int userId, int transactionId)
        {
            CreateTransactionWindowAction(userId, transactionId);
        }

        public void LoadTransactions(int userId)
        {
            TransactionsClass.LoadTransactions(userId);
        }
    }
}
