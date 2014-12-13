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
            using (var db = new DatabaseContext())
            {
                Transactions = new ObservableCollection<dynamic>(db.TransactionUsers
                    .Where(x => x.ID_user == 3)
                    .Select(x => new
                    {
                        x.Transaction.Date,
                        x.Transaction.Description,
                        x.Sum,
                        AuthorName = x.Transaction.User.Name,
                    }));
            }
        }

        private ObservableCollection<dynamic> transactions;

        public ObservableCollection<dynamic> Transactions
        {
            get { return transactions; }
            set
            {
                if (transactions != value)
                {
                    transactions = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
