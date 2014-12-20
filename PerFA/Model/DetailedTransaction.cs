using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
using PerFA.Model.Database;
using PerFA.Model.TransactionTypes;

namespace PerFA.Model
{
    class DetailedTransaction : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        //private Dictionary<string, decimal?> usersSumsDictionary;
        
        public readonly TransactionUser transactionUser;

        public DetailedTransaction(TransactionUser transactionUser)
        {
            this.transactionUser = transactionUser;
            if (transactionUser.Transaction.HouseholdExpence != null)
            {
                householdExpensesDetails = 
                    new DTHouseholdExpenses(transactionUser.Transaction.HouseholdExpence);
                type = "Побутові витрати";
            }
            else if (transactionUser.Transaction.Wage != null)
            {
                wageDetails = new DTWage(transactionUser.Transaction.Wage);
                type = "Заробітня плата";
            }
        }
        
        public DateTime? Date
        {
            get { return transactionUser.Transaction.Date; }
            set
            {
                if (transactionUser.Transaction.Date != value)
                {
                    transactionUser.Transaction.Date = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return transactionUser.Transaction.Description; }
            set
            {
                if (transactionUser.Transaction.Description != value)
                {
                    transactionUser.Transaction.Description = value;
                    OnPropertyChanged();
                }
            }
        }

        public string UserName
        {
            get { return transactionUser.User.Name; }
        }

        public decimal? Sum
        {
            get { return transactionUser.Sum; }
            set
            {
                if (transactionUser.Sum != value)
                {
                    transactionUser.Sum = value;
                    OnPropertyChanged();
                }
            }
        }

        public string AuthorName
        {
            get { return transactionUser.Transaction.User.Name; }
        }

        //public ICollection<TransactionUser> UsersSumsDictionary
        //{
        //    get { return transactionUser.Transaction.TransactionUsers; }
        //    set
        //    {
        //        if (transactionUser.Transaction.TransactionUsers != value)
        //        {
        //            transactionUser.Transaction.TransactionUsers = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        private readonly string type;
        public string Type
        {
            get { return type; }
        }

        private readonly DTHouseholdExpenses householdExpensesDetails;
        public DTHouseholdExpenses HouseholdExpensesDetails
        {
            get { return householdExpensesDetails; }
        }

        public bool HasHouseholdExpensesDetails
        {
            get { return householdExpensesDetails != null; }
        }

        private readonly DTWage wageDetails;
        public DTWage WageDetails
        {
            get { return wageDetails; }
        }

        public bool HasWageDetails
        {
            get { return wageDetails != null; }
        }

    }
}
