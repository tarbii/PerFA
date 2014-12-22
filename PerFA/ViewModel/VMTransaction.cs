using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;
using PerFA.View;
using PropertyChanged;

namespace PerFA.ViewModel
{
    [ImplementPropertyChanged]
    class VMTransaction
    {
        public TransactionClass Transaction { get; set; }
        public SaveChangesCommand SaveChangesCommand { get; set; }
        public RelayCommand DeleteTransactionUserCommand { get; private set; }
        public RelayCommand AddTransactionUserCommand { get; private set; }

        public VMTransaction()
        {
            Transaction = new TransactionClass();
            //Transaction.ChangesSaved += Transaction_ChangesSaved;
            SaveChangesCommand = new SaveChangesCommand(Transaction);
            DeleteTransactionUserCommand = new RelayCommand(o =>
                Transaction.Transaction.MultiuserManager.DeleteTransactionUser());
            AddTransactionUserCommand = new RelayCommand(o => 
                Transaction.Transaction.MultiuserManager.AddTransactionUser());
        }

        //void Transaction_ChangesSaved() { }

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
