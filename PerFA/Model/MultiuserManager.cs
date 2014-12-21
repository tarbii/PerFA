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
        { get; private set; }

        public ObservableCollection<User> OtherUsers { get; private set; }
        public User SelectedUser { get; set; }

        public TransactionUser SelectedTransactionUser { get; set; }

        private void LoadTransactionUsersCollection()
        {
            var transactionUsers = db.TransactionUsers
                .Where(x => x.ID_transaction == transactionId);
            TransactionUsersCollection = new ObservableCollection<TransactionUser>(transactionUsers);

            var otherUsers = db.Users.Where(u => !db.TransactionUsers
                .Where(x => x.ID_transaction == transactionId).Any(tu =>
                u.ID == tu.User.ID));
            OtherUsers = new ObservableCollection<User>(otherUsers);
            SelectedUser = OtherUsers.FirstOrDefault();
        }

        public void DeleteTransactionUser(object parameter)
        {
            if (SelectedTransactionUser != null)
            {
                OtherUsers.Add(SelectedTransactionUser.User);
                
                db.TransactionUsers.Remove(SelectedTransactionUser);

                TransactionUsersCollection.Remove(SelectedTransactionUser);
                SelectedUser = OtherUsers.FirstOrDefault();
            }
        }
        
        public void AddTransactionUser()
        {
            if (SelectedUser != null)
            {
                var thisTu = TransactionUsersCollection.First();
                var tu = db.TransactionUsers.Create();
                tu.Transaction = thisTu.Transaction;
                tu.User = SelectedUser;
                db.TransactionUsers.Add(tu);

                TransactionUsersCollection.Add(tu);
                OtherUsers.Remove(SelectedUser);
                SelectedUser = OtherUsers.FirstOrDefault();
            }
        }

        public ICollection Collection { get; set; }
    }
}
