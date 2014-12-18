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
    class TransactionClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private TransactionPresentation transaction;

        public TransactionPresentation Transaction
        {
            get { return transaction; }
            set
            {
                if (transaction != value)
                {
                    transaction = value;
                    OnPropertyChanged();
                }
            }
        }

        public void LoadTransaction(int userId, int transactionId)
        {
            using (var db = new DatabaseContext())
            {
                Transaction = db.TransactionUsers
                    .Where(x => x.ID_user == userId && x.ID_transaction == transactionId)
                    .Select(x => new TransactionPresentation
                    {
                        Description = x.Transaction.Description,
                        AuthorName = x.Transaction.User.Name,
                        Sum = x.Sum,
                        Date = x.Transaction.Date,
                        UserId = x.ID_user,
                        TransactionId = x.ID_transaction
                    }).First();
            }
        }
    }
}
