using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
using PerFA.Model.Database;

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

        public AllTransactionsClass()
        {
            NamesOfTransaction = new NamesOfTransaction().NamesList;
        }

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

        public void LoadTransactions(int userId)
        {
            using (var db = new DatabaseContext())
            {
                Transactions = new ReadOnlyObservableCollection<TransactionPresentation>(
                    new ObservableCollection<TransactionPresentation>(db.TransactionUsers
                        .Where(x => x.ID_user == userId)
                        .Select(x => new TransactionPresentation
                        {
                            Description = x.Transaction.Description,
                            AuthorName = x.Transaction.User.Name,
                            Sum = x.Sum,
                            Date = x.Transaction.Date,
                            UserId = x.ID_user,
                            TransactionId = x.ID_transaction
                        })));
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
            private set
            {
                if (selectedNameOfTransaction != value)
                {
                    selectedNameOfTransaction = value;
                    OnPropertyChanged();
                }
            }
        }

        public event Action TransactionCreationucceed;
        private void OnTransactionCreationSucceed()
        {
            var handler = TransactionCreationucceed;
            if (handler != null) handler();
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
                OnTransactionCreationSucceed();
            }
            else
            {
                OnTransactionCreationFailed("Виберіть тип транзакції для створення");
            }
        }

    }
}
