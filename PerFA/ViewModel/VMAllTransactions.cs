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

        public ViewTransactionCommand ViewTransactionCommand { get; set; }

        public CreateTransactionCommand CreateTransactionCommand { get; set; }

        public AllTransactionsClass AllTransactionsClass { get; set; }

        public VMAllTransactions()
        {
            AllTransactionsClass = new AllTransactionsClass();
            AllTransactionsClass.TransactionLoadSucceed += 
                TransactionsClass_TransactionLoadSucceed;
            AllTransactionsClass.TransactionLoadFailed += TransactionsClass_TransactionLoadFailed;
            ViewTransactionCommand = new ViewTransactionCommand(AllTransactionsClass);
            CreateTransactionCommand = new CreateTransactionCommand(AllTransactionsClass);
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
            AllTransactionsClass.LoadTransactions(userId);
        }
    }
}
