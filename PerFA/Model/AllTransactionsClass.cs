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

namespace PerFA.Model
{
    class AllTransactionsClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private int? userId;
        public AllTransactionsClass()
        {
            NamesOfTransaction = new NamesOfTransaction().NamesList;
            TypeFilter.Changed += Update;
        }

        private readonly Filters.TypeFilter typeFilter = new Filters.TypeFilter(true);
        public Filters.TypeFilter TypeFilter { get { return typeFilter; } }

        private TransactionPresentation selectedTransaction;
        public TransactionPresentation SelectedTransaction
        {
            get { return selectedTransaction; }
            set
            {
                if (selectedTransaction != value)
                {
                    selectedTransaction = value;
                    OnPropertyChanged();
                }
            }
        }

        private ReadOnlyObservableCollection<TransactionPresentation> transactions;
        public ReadOnlyObservableCollection<TransactionPresentation> Transactions
        {
            get { return transactions; }
            private set
            {
                if (transactions != value)
                {
                    transactions = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal income;
        public decimal Income
        {
            get { return income; }
            private set
            {
                if (income != value)
                {
                    income = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal expences;
        public decimal Expences
        {
            get { return expences; }
            private set
            {
                if (expences != value)
                {
                    expences = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (balance != value)
                {
                    balance = value;
                    OnPropertyChanged();
                }
            }
        }

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
            using (var db = new DatabaseContext())
            {
                Transactions = new ReadOnlyObservableCollection<TransactionPresentation>(
                    new ObservableCollection<TransactionPresentation>(db.TransactionUsers
                        .Where(x => (x.ID_user == uId) &&
                            ((TypeFilter.WageChecked && x.Transaction.Wage != null)
                            || (TypeFilter.HouseholdExpensesChecked && x.Transaction.HouseholdExpence != null)))
                        .Select(x => new TransactionPresentation
                        {
                            Description = x.Transaction.Description,
                            AuthorName = x.Transaction.User.Name,
                            Sum = x.Sum,
                            Date = x.Transaction.Date,
                            UserId = x.ID_user,
                            TransactionId = x.ID_transaction
                        })));

                Income = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Where(s => s > 0).Sum();
                Expences = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Where(s => s < 0).Sum();
                Balance = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Sum();
            }
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
                    SelectedTransaction.UserId, SelectedTransaction.TransactionId);
            }
            else
            {
                OnTransactionLoadFailed("Select transaction.");
            }
        }

        public List<string> NamesOfTransaction { get; private set; }

        private string selectedNameOfTransaction;
        public string SelectedNameOfTransaction
        {
            get { return selectedNameOfTransaction; }
            set
            {
                if (selectedNameOfTransaction != value)
                {
                    selectedNameOfTransaction = value;
                    OnPropertyChanged();
                }
            }
        }

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
                        x.ID_transaction == SelectedTransaction.TransactionId &&
                        x.ID_user == SelectedTransaction.UserId));
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
