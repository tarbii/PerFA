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
        private User user;
        private readonly Transaction transaction;
        private readonly List<User> allUsers; 

        public MultiuserManager(DatabaseContext db, User user, Transaction transaction)
        {
            this.db = db;
            this.user = user;
            this.transaction = transaction;
            allUsers = db.Users.ToList();
            LoadTransactionUsersCollection();
        }

        public ObservableCollection<TransactionUser> TransactionUsersCollection 
        { get; private set; }

        public ObservableCollection<User> OtherUsers { get; private set; }
        public User SelectedUser { get; set; }

        public TransactionUser SelectedTransactionUser { get; set; }

        private void LoadTransactionUsersCollection()
        {
            var transactionUsers = transaction.TransactionUsers;
            TransactionUsersCollection = new ObservableCollection<TransactionUser>(transactionUsers);

            var otherUsers = allUsers.Except(transactionUsers.Select(tu => tu.User));
            OtherUsers = new ObservableCollection<User>(otherUsers);
            SelectedUser = OtherUsers.FirstOrDefault();
        }

        public void DeleteTransactionUser()
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
