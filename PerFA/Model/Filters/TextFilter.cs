using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;

namespace PerFA.Model.Filters
{
    class TextFilter : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public TextFilter()
        {
            DescriptionChecked = true;
        }

        private string searchTerm;
        public string SearchTerm
        {
            get { return searchTerm; }
            set
            {
                if (searchTerm != value)
                {
                    searchTerm = value.ToLower();
                    OnPropertyChanged();
                }
            }
        }

        private bool everywhereChecked;
        public bool EverywhereChecked
        {
            get { return everywhereChecked; }
            set
            {
                if (everywhereChecked != value)
                {
                    everywhereChecked = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool descriptionChecked;
        public bool DescriptionChecked
        {
            get { return descriptionChecked; }
            set
            {
                if (descriptionChecked != value)
                {
                    descriptionChecked = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
