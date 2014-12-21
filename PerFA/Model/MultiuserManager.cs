using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using PerFA.Annotations;
using PerFA.ViewModel;
using PropertyChanged;

namespace PerFA.Model
{
    [ImplementPropertyChanged]
    class MultiuserManager
    {
        private DatabaseContext db;
        private int userId;
        private readonly int transactionId;

        public MultiuserManager(DatabaseContext db, int uId, int tId)
        {
            this.db = db;
            userId = uId;
            transactionId = tId;
            LoadTransactionUsersCollection();
        }

        public ObservableCollection<TransactionUser> TransactionUsersCollection 
        { get; set; }

        public TransactionUser SelectedTransactionUser { get; set; }

        public void DeleteTransactionUser(object parameter)
        {
            if (SelectedTransactionUser != null)
            {
                db.TransactionUsers.Remove(db.TransactionUsers.First(x =>
                    x.ID_transaction == SelectedTransactionUser.ID_transaction
                    && x.ID_user == SelectedTransactionUser.ID_user));
                
                LoadTransactionUsersCollection();
            }
        }

        private void LoadTransactionUsersCollection()
        {
            var transactionUsers = db.TransactionUsers
                .Where(x => x.ID_transaction == transactionId);
            TransactionUsersCollection = new ObservableCollection<TransactionUser>(transactionUsers);
        }
    }
}
