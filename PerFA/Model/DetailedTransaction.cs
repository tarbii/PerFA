using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
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

        public int UserId;
        public int TransactionId;

        private DateTime? date;
        private string description;
        private string userName;
        private decimal? sum;
        private string authorName;
        private Dictionary<string, decimal?> usersSumsDictionary;
        private string type;
        private DTHouseholdExpenses householdExpensesDetails;
        private DTWage wageDetails;

        public DateTime? Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        public string UserName
        {
            get { return userName; }
            set
            {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }
        }

        public decimal? Sum
        {
            get { return sum; }
            set
            {
                if (sum != value)
                {
                    sum = value;
                    OnPropertyChanged();
                }
            }
        }

        public string AuthorName
        {
            get { return authorName; }
            set
            {
                if (authorName != value)
                {
                    authorName = value;
                    OnPropertyChanged();
                }
            }
        }

        public Dictionary<string, decimal?> UsersSumsDictionary
        {
            get { return usersSumsDictionary; }
            set
            {
                if (usersSumsDictionary != value)
                {
                    usersSumsDictionary = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    OnPropertyChanged();
                }
            }
        }

        public DTHouseholdExpenses HouseholdExpensesDetails
        {
            get { return householdExpensesDetails; }
            set
            {
                if (householdExpensesDetails != value)
                {
                    var householdTransactionChanged = 
                        (householdExpensesDetails != null) != (value != null);
                    householdExpensesDetails = value;
                    OnPropertyChanged();
                    if (householdTransactionChanged)
                    {
                        OnPropertyChanged("IsHouseholdExpensesTransaction"); 
                    }
                }
            }
        }

        public DTWage WageDetails
        {
            get { return wageDetails; }
            set
            {
                if (wageDetails != value)
                {
                    var wageTransactionChanged = (wageDetails != null) != (value != null);
                    wageDetails = value;
                    OnPropertyChanged();
                    if (wageTransactionChanged)
                    {
                        OnPropertyChanged("IsWageTransaction");
                    }
                }
            }
        }

        public bool IsHouseholdExpensesTransaction
        {
            get { return HouseholdExpensesDetails != null; }
        }

        public bool IsWageTransaction
        {
            get { return WageDetails != null; }
        }

    }
}
