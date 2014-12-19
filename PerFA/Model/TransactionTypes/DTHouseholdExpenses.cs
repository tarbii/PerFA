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

        private string subType;
        private string comment;

        public string SubType
        {
            get { return subType; }
            set
            {
                if (subType != value)
                {
                    subType = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Comment
        {
            get { return comment; }
            set
            {
                if (comment != value)
                {
                    comment = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
