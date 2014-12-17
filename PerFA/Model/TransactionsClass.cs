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
    class TransactionsClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public TransactionsClass()
        {
        }

        private ReadOnlyObservableCollection<TransactionPresentation> transactions;
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
                            Date = x.Transaction.Date
                        })));
            }
        }
    }
}
