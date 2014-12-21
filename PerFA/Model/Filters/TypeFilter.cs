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

        //TODO: add transaction types (propertiess)

        private IEnumerable<bool> EnumerateCheckeds()
        {
            //TODO: add transaction types
            yield return WageChecked;
            yield return HouseholdExpensesChecked;
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
                //TODO: add transaction types
                HouseholdExpensesChecked
                    = WageChecked
                    = value.Value;
                muted = false;

                OnChanged();
            }
        }
    }
}
