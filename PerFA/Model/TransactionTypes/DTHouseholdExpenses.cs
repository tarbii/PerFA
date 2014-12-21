using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;

namespace PerFA.Model.TransactionTypes
{
    class DTHouseholdExpenses : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly HouseholdExpence householdExpence;
        public DTHouseholdExpenses(HouseholdExpence householdExpence)
        {
            this.householdExpence = householdExpence;
        }

        public string SubType
        {
            get { return householdExpence.HE_type; }
            set
            {
                if (householdExpence.HE_type != value)
                {
                    householdExpence.HE_type = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Comment
        {
            get { return householdExpence.Comment; }
            set
            {
                if (householdExpence.Comment != value)
                {
                    householdExpence.Comment = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
