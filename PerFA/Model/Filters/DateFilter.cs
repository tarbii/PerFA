using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
using PropertyChanged;

namespace PerFA.Model.Filters
{
    class DateFilter : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private DateTime? from;
        public DateTime? From
        {
            get { return from; }
            set
            {
                if (from != value)
                {
                    from = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTime? to;
        public DateTime? To
        {
            get { return to; }
            set
            {
                if (to != value)
                {
                    to = value;
                    OnPropertyChanged();
                }
            }
        }

        public void Reset()
        {
            From = null;
            To = null;
        }
    }
}
