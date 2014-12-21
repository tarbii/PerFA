using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using PerFA.Annotations;

namespace PerFA.Model.Filters
{
    class TypeFilter : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) { handler(this, new PropertyChangedEventArgs(propertyName)); }
        }


        public event Action Changed;
        private bool muted;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnChanged([CallerMemberName] string propertyName = null)
        {

            if (propertyName != null)
            {
                OnPropertyChanged(propertyName);
            }

            if (muted)
            {
                return;
            }

            OnPropertyChanged("AllChecked");

            var handler = Changed;
            if (handler != null) { handler(); }
        }


        public TypeFilter(bool initialState = false)
        {
            AllChecked = initialState;
        }

        private bool wageChecked;
        public bool WageChecked
        {
            get { return wageChecked; }
            set
            {
                if (wageChecked != value)
                {
                    wageChecked = value;
                    OnChanged();
                }
            }
        }

        private bool householdExpensesChecked;
        public bool HouseholdExpensesChecked
        {
            get { return householdExpensesChecked; }
            set
            {
                if (householdExpensesChecked != value)
                {
                    householdExpensesChecked = value;
                    OnChanged();
                }
            }
        }

        private bool incomeOnDepositChecked;
        public bool IncomeOnDepositChecked
        {
            get { return incomeOnDepositChecked; }
            set
            {
                if (incomeOnDepositChecked != value)
                {
                    incomeOnDepositChecked = value;
                    OnChanged();
                }
            }
        }

        private bool scholarshipChecked;
        public bool ScholarshipChecked
        {
            get { return scholarshipChecked; }
            set
            {
                if (scholarshipChecked != value)
                {
                    scholarshipChecked = value;
                    OnChanged();
                }
            }
        }
        
        private bool otherIncomeChecked;
        public bool OtherIncomeChecked
        {
            get { return otherIncomeChecked; }
            set
            {
                if (otherIncomeChecked != value)
                {
                    otherIncomeChecked = value;
                    OnChanged();
                }
            }
        }
        
        private bool rentChecked;
        public bool RentChecked
        {
            get { return rentChecked; }
            set
            {
                if (rentChecked != value)
                {
                    rentChecked = value;
                    OnChanged();
                }
            }
        }
        
        private bool creditExpensesChecked;
        public bool CreditExpensesChecked
        {
            get { return creditExpensesChecked; }
            set
            {
                if (creditExpensesChecked != value)
                {
                    creditExpensesChecked = value;
                    OnChanged();
                }
            }
        }
        
        private bool longTermldExpensesChecked;
        public bool LongTermldExpensesChecked
        {
            get { return longTermldExpensesChecked; }
            set
            {
                if (longTermldExpensesChecked != value)
                {
                    longTermldExpensesChecked = value;
                    OnChanged();
                }
            }
        }
        
        private bool otherdExpensesChecked;
        public bool OtherdExpensesChecked
        {
            get { return otherdExpensesChecked; }
            set
            {
                if (otherdExpensesChecked != value)
                {
                    otherdExpensesChecked = value;
                    OnChanged();
                }
            }
        }

        private IEnumerable<bool> EnumerateCheckeds()
        {
            yield return WageChecked;
            yield return HouseholdExpensesChecked;
            yield return IncomeOnDepositChecked;
            yield return ScholarshipChecked;
            yield return OtherIncomeChecked;
            yield return RentChecked;
            yield return CreditExpensesChecked;
            yield return LongTermldExpensesChecked;
            yield return OtherdExpensesChecked;
        } 

        public bool? AllChecked
        {
            get
            {
                if (EnumerateCheckeds().All(c => c))
                {
                    return true;
                }
                if (EnumerateCheckeds().All(c => !c))
                {
                    return false;
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                muted = true;
                HouseholdExpensesChecked
                    = WageChecked
                    = IncomeOnDepositChecked
                    = ScholarshipChecked
                    = OtherIncomeChecked
                    = RentChecked
                    = CreditExpensesChecked
                    = LongTermldExpensesChecked
                    = OtherdExpensesChecked
                    = value.Value;
                muted = false;

                OnChanged();
            }
        }
    }
}
