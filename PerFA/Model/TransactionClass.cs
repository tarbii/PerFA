using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;

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

        public TransactionClass()
        {
            db = new DatabaseContext();
        }

        private DetailedTransaction transaction;
        private readonly DatabaseContext db;

        public DetailedTransaction Transaction
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

        public void LoadTransaction(int userId, int? transactionId)
        {
            var transactionUser = db.TransactionUsers
                .First(x => x.ID_user == userId && x.ID_transaction == transactionId);
            Transaction = new DetailedTransaction(transactionUser, db);

        }

        public void CreateTransaction(int userId, string typeOfTransaction)
        {
            var tu = db.TransactionUsers.Create();
            tu.ID_user = userId;

            var t = tu.Transaction = db.Transactions.Create();
            t.Author_ID = userId;

            db.Transactions.Add(t);
            db.TransactionUsers.Add(tu);

            switch (typeOfTransaction)
            {
                case "Household expenses":
                    var hexp = db.HouseholdExpences.Create();
                    hexp.Transaction = t;
                    db.HouseholdExpences.Add(hexp);
                    break;

                case "Wage":
                    var cExp = db.Wages.Create();
                    cExp.Transaction = t;
                    db.Wages.Add(cExp);
                    break;

                case "Income on deposit":
                    var inDep = db.Deposits.Create();
                    inDep.Transaction = t;
                    db.Deposits.Add(inDep);
                    break;

                case "Scholarship":
                    var sch = db.Grants.Create();
                    sch.Transaction = t;
                    db.Grants.Add(sch);
                    break;

                case "Other income":
                    var oi = db.OtherIncomes.Create();
                    oi.Transaction = t;
                    db.OtherIncomes.Add(oi);
                    break;

                case "Rent":
                    var rent = db.Rents.Create();
                    rent.Transaction = t;
                    db.Rents.Add(rent);
                    break;

                case "Credit expenses":
                    var credit = db.Credits.Create();
                    credit.Transaction = t;
                    db.Credits.Add(credit);
                    break;

                case "Long term expenses":
                    var longTerm = db.LongTermExpences.Create();
                    longTerm.Transaction = t;
                    db.LongTermExpences.Add(longTerm);
                    break;

                case "Other expences":
                    var otherExp = db.OtherExpences.Create();
                    otherExp.Transaction = t;
                    db.OtherExpences.Add(otherExp);
                    break;
            }

            Transaction = new DetailedTransaction(tu, db);
        }

        public event Action ChangesSaved;

        protected virtual void OnChangesSaved()
        {
            var handler = ChangesSaved;
            if (handler != null) handler();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
            OnChangesSaved();
        }
    }
}
