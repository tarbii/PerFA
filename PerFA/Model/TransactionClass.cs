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
using PerFA.Model.Database;
using PerFA.Model.TransactionTypes;

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
            //var users = db.TransactionUsers.Where(x => x.ID_transaction == transactionId)
            //    .Select(x => new { x.User.Name, x.Sum })
            //    .ToDictionary(x => x.Name, x => x.Sum);

            //Transaction = db.TransactionUsers
            //    .Where(x => x.ID_user == userId && x.ID_transaction == transactionId)
            //    .Select(x => new DetailedTransaction
            //    {
            //        Description = x.Transaction.Description,
            //        UserName = x.User.Name,
            //        AuthorName = x.Transaction.User.Name,
            //        Sum = x.Sum,
            //        Date = x.Transaction.Date,
            //        UserId = userId,
            //        TransactionId = transactionId,
            //    }).First();

            //SetTypeofTransaction(db);
            //Transaction.UsersSumsDictionary = users;

            var transactionUser = db.TransactionUsers
                .First(x => x.ID_user == userId && x.ID_transaction == transactionId);
            Transaction = new DetailedTransaction(transactionUser);

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
                case "Побутові витрати":
                    var hexp = db.HouseholdExpences.Create();
                    hexp.Transaction = t;
                    db.HouseholdExpences.Add(hexp);
                    break;

                case "Заробітня плата":
                    var wage = db.Wages.Create();
                    wage.Transaction = t;
                    db.Wages.Add(wage);
                    break;

            }

            Transaction = new DetailedTransaction(tu);
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

        //private void SetTypeofTransaction(DatabaseContext db)
        //{
        //    if (db.Credits.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = "Витрати по кредиту";
        //        return;
        //    }
        //    if (db.Deposits.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = "Дохід по депозиту";
        //        return;
        //    }
        //    if (db.Grants.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = "Стипендія";
        //        return;
        //    }
        //    if (db.HouseholdExpences.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = "";
        //        Transaction.HouseholdExpensesDetails = db.HouseholdExpences
        //            .Where(x => x.ID == Transaction.TransactionId)
        //            .Select(x => new DTHouseholdExpenses
        //            {
        //                SubType = x.HE_type,
        //                Comment = x.Comment
        //            }).First();
        //        return;
        //    }
        //    if (db.LongTermExpences.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = "Довгострокові витрати";
        //        return;
        //    }
        //    if (db.OtherExpences.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = "Витрати";
        //        return;
        //    }
        //    if (db.OtherIncomes.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = "Інший дохід";
        //        return;
        //    }
        //    if (db.Rents.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = "Оренда житла";
        //        return;
        //    }
        //    if (db.Wages.Any(x => x.ID == Transaction.TransactionId))
        //    {
        //        Transaction.Type = ;
        //        Transaction.WageDetails = db.Wages
        //            .Where(x => x.ID == Transaction.TransactionId)
        //            .Select(x => new DTWage
        //            {
        //                WorkPlace = x.Workplace,
        //                WageRate = x.Wage_rate
        //            }).First();
        //        return;
        //    }
        //    Transaction.Type = "Тип транзакції невідомий";
        //}
    }
}
