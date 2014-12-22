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

        public Action RegistrationSucced { get; set; }

        public Action<string> RegistrationFailed { get; set; }

        public VMRegistration()
        {
            Registration = new Registration();
            RegistrateCommand = new RegistrateCommand(Registration);
            Registration.RegistrationSucced += Registration_RegistrationSucced;
            Registration.RegistrationFailed += Registration_RegistrationFailed;
        }

        void Registration_RegistrationFailed(string obj)
        {
           RegistrationFailed(obj);
        }

        void Registration_RegistrationSucced()
        {
            RegistrationSucced();
        }
    }
}
