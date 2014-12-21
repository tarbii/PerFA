using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;
using PerFA.View;

namespace PerFA.ViewModel
{
    class VMTransaction
    {
        public TransactionClass Transaction { get; set; }
        public SaveChangesCommand SaveChangesCommand { get; set; }
        public RelayCommand DeleteTransactionUserCommand { get; private set; }

        public VMTransaction()
        {
            Transaction = new TransactionClass();
            Transaction.ChangesSaved += Transaction_ChangesSaved;
            SaveChangesCommand = new SaveChangesCommand(Transaction);
        }

        void Transaction_ChangesSaved() { }

        public void LoadTransaction(int userId, int? transactionId)
        {
            Transaction.LoadTransaction(userId, transactionId);
            DeleteTransactionUserCommand = new RelayCommand(
               Transaction.Transaction.MultiuserManager.DeleteTransactionUser);
        }

        public void CreateTransaction(int userId, string typeOfTransaction)
        {
            Transaction.CreateTransaction(userId, typeOfTransaction);
        }
    }
}
