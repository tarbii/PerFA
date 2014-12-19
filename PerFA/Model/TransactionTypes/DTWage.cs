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
    class DTWage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string workPlace;
        private decimal? wageRate;

        public string WorkPlace
        {
            get { return workPlace; }
            set
            {
                if (workPlace != value)
                {
                    workPlace = value;
                    OnPropertyChanged();
                }
            }
        }

        public decimal? WageRate
        {
            get { return wageRate; }
            set
            {
                if (wageRate != value)
                {
                    wageRate = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
