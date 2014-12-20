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
        public Action CloseWindowAction { get; set; }
        public TransactionClass Transaction { get; set; }
        public SaveChangesCommand SaveChangesCommand { get; set; }

        public VMTransaction()
        {
            Transaction = new TransactionClass();
            Transaction.ChangesSaved += Transaction_ChangesSaved;
            SaveChangesCommand = new SaveChangesCommand(Transaction);
        }

        void Transaction_ChangesSaved()
        {
            CloseWindowAction();
        }

        public void LoadTransaction(int userId, int? transactionId)
        {
            Transaction.LoadTransaction(userId, transactionId);
        }

        public void CreateTransaction(int userId, string typeOfTransaction)
        {
            Transaction.CreateTransaction(userId, typeOfTransaction);
        }
    }
}
