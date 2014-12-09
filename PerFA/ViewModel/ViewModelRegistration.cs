using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class ViewModelRegistration
    {
        public Registration Registration { get; set; }

        public RegistrateCommand RegistrateCommand { get; set; }

        public ViewModelRegistration()
        {
            Registration = new Registration();
            RegistrateCommand = new RegistrateCommand(Registration);
        }
    }
}
