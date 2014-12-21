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
using PerFA.Annotations;
using PerFA.Model.Database;

namespace PerFA.Model
{
    class MultiuserManager : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private DatabaseContext db;
        private int userId;
        private int transactionId;

        public MultiuserManager(DatabaseContext db, int uId, int tId)
        {
            this.db = db;
            userId = uId;
            transactionId = tId;
            var transactionUsers = db.TransactionUsers
                .Where(x => x.ID_transaction == transactionId);
            TuCollection = new ReadOnlyObservableCollection<TransactionUser>(
                new ObservableCollection<TransactionUser>(transactionUsers));

        }


        private ReadOnlyObservableCollection<TransactionUser> tuCollection;
        public ReadOnlyObservableCollection<TransactionUser> TuCollection
        {
            get { return tuCollection; }
            set
            {
                if (tuCollection != value)
                {
                    tuCollection = value;
                    OnPropertyChanged();
                }
            }
        }  
    }
}
