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

        private readonly Wage wage;

        public DTWage(Wage wage)
        {
            this.wage = wage;
        }

        public string WorkPlace
        {
            get { return wage.Workplace; }
            set
            {
                if (wage.Workplace != value)
                {
                    wage.Workplace = value;
                    OnPropertyChanged();
                }
            }
        }

        public decimal? WageRate
        {
            get { return wage.Wage_rate; }
            set
            {
                if (wage.Wage_rate != value)
                {
                    wage.Wage_rate = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
