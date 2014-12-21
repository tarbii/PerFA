using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
using PropertyChanged;

namespace PerFA.Model
{
    [ImplementPropertyChanged]
    class AllTransactionsClass
    {
        private int? userId;
        public AllTransactionsClass()
        {
            NamesOfTransaction = new NamesOfTransaction().NamesList;
            TypeFilter.Changed += Update;
        }

        private readonly Filters.TypeFilter typeFilter = new Filters.TypeFilter(true);
        public Filters.TypeFilter TypeFilter { get { return typeFilter; } }

        public TransactionUser SelectedTransaction { get; set; }

        public ObservableCollection<TransactionUser> Transactions { get; set; }

        public decimal Income { get; set; }
        public decimal Expences { get; set; }
        public decimal Balance { get; set; }


        public void Initialize(int uId)
        {
            userId = uId;
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            if (userId == null)
            {
                throw new Exception("Cannot load transatcions: user is not set");
            }

            var uId = userId.Value;

            Debug.WriteLine("Loading transactions for {0}", uId);
            var db = new DatabaseContext();
            Transactions = new ObservableCollection<TransactionUser>(db.TransactionUsers
                    .Where(x => (x.ID_user == uId) &&
                        ((TypeFilter.WageChecked && x.Transaction.Wage != null)
                        || (TypeFilter.HouseholdExpensesChecked && 
                                x.Transaction.HouseholdExpence != null)))
                    .Select(x => x));

            Income = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Where(s => s > 0).Sum();
            Expences = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Where(s => s < 0).Sum();
            Balance = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Sum();
            
        }

        public event Action<int, int> TransactionLoadSucceed;
        private void OnTransactionLoadSucceed(int userId, int transactionId)
        {
            var handler = TransactionLoadSucceed;
            if (handler != null) handler(userId, transactionId);
        }

        public event Action<string> TransactionLoadFailed;
        private void OnTransactionLoadFailed(string message)
        {
            var handler = TransactionLoadFailed;
            if (handler != null) handler(message);
        }

        public void TryLoadTransaction()
        {
            if (SelectedTransaction != null)
            {
                OnTransactionLoadSucceed(
                    SelectedTransaction.ID_user, SelectedTransaction.ID_transaction);
            }
            else
            {
                OnTransactionLoadFailed("Select transaction.");
            }
        }

        public List<string> NamesOfTransaction { get; private set; }

        public string SelectedNameOfTransaction { get; set; }

        public event Action<string> TransactionCreationucceed;
        private void OnTransactionCreationSucceed(string typeOfTransaction)
        {
            var handler = TransactionCreationucceed;
            if (handler != null) handler(typeOfTransaction);
        }

        public event Action<string> TransactionCreationFailed;
        private void OnTransactionCreationFailed(string message)
        {
            var handler = TransactionCreationFailed;
            if (handler != null) handler(message);
        }

        public void TryCreateTransaction()
        {
            if (SelectedNameOfTransaction != null)
            {
                OnTransactionCreationSucceed(SelectedNameOfTransaction);
            }
            else
            {
                OnTransactionCreationFailed("Виберіть тип транзакції для створення");
            }
        }

        public void DeleteTransaction()
        {
            if (SelectedTransaction != null)
            {
                using (var db = new DatabaseContext())
                {
                    db.TransactionUsers.Remove(db.TransactionUsers.First(x =>
                        x.ID_transaction == SelectedTransaction.ID_transaction &&
                        x.ID_user == SelectedTransaction.ID_user));
                    db.SaveChanges();
                }
                LoadTransactions();
            }
        }


        public void Update()
        {
            LoadTransactions();
        }
    }
}
