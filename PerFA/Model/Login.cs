using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
using PerFA.Model.Database;

namespace PerFA.Model
{
    class Login : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        public Login()
        {
            Database = new DatabaseContext();
        }

        public DatabaseContext Database;
        private string loginId;
        private string password;
        private string loginMessage = "Enter login & password";

        public string LoginMessage
        {
            get { return loginMessage; }
            private set
            {
                if (loginMessage != value)
                {
                    loginMessage = value;
                    OnPropertyChanged();
                }
            }
        }

        public string LoginId
        {
            get { return loginId; }
            private set
            {
                if (loginId != value)
                {
                    loginId = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return password; }
            private set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public void TryLogin()
        {
            var users = Database.Users.ToList();
            foreach (var user in Database.Users)
            {
                LoginMessage += user.Name;
            }
            return;
            var t =
                (from user in Database.Users where user.Login == LoginId && user.Password == Password select user)
                    .FirstOrDefault();
            var b = (Database.Users.Where(x => x.Login == LoginId && x.Password == Password)).FirstOrDefault();



            if (b != null)
            {
                LoginMessage = "OK";
            }
            else
            {
                LoginMessage = "HUYOK";
                
            }

        }

    }
}
