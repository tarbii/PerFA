using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class VMRegistration
    {
        public Registration Registration { get; set; }

        public RegistrateCommand RegistrateCommand { get; set; }

        public VMRegistration()
        {
            Registration = new Registration();
            RegistrateCommand = new RegistrateCommand(Registration);
        }
    }
}
