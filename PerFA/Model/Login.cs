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
        }

        private string loginData = "alex";
        private string password = "alex";
        private string loginMessage = "Enter login & password";

        public int UserId { get; set; }

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

        public string LoginData
        {
            get { return loginData; }
            set
            {
                if (loginData != value)
                {
                    loginData = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool TryLogin()
        {
            using (var db = new DatabaseContext())
            {
                var user = (db.Users.Where(x => x.Login == LoginData && x.Password == Password)).FirstOrDefault();
                if (user != null)
                {
                    UserId = user.ID;
                    Password = "";
                    return true;
                }
                LoginMessage = db.Users.Select(x => x.Login).Contains(loginData) ? "Wrong password" : "Wrong login";
                Password = "";
                return false;
            }
        }
    }
}
