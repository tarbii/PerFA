using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PerFA.Annotations;

namespace PerFA.Model
{
    class Registration : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;
        private string login;
        private string password;
        private string passwordCheck;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Login
        {
            get { return login; }
            set
            {
                if (login != value)
                {
                    login = value;
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

        public string PasswordCheck
        {
            get { return passwordCheck; }
            set
            {
                if (passwordCheck != value)
                {
                    passwordCheck = value;
                    OnPropertyChanged();
                }
            }
        }

        public event Action RegistrationSucced;
        protected virtual void OnRegistrationSucced()
        {
            Action handler = RegistrationSucced;
            if (handler != null) handler();
        }

        public event Action<string> RegistrationFailed;
        protected virtual void OnRegistrationFailed(string obj)
        {
            Action<string> handler = RegistrationFailed;
            if (handler != null) handler(obj);
        }

        public void Registrate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                OnRegistrationFailed("Name is not set.");
                Password = PasswordCheck = "";
                return;
            }

            if (string.IsNullOrEmpty(Login))
            {
                OnRegistrationFailed("Login is not set.");
                Password = PasswordCheck = "";
                return;
            }
            
            if (string.IsNullOrEmpty(Password))
            {
                OnRegistrationFailed("Password is not set.");
                Password = PasswordCheck = "";
                return;
            }

            if (Password != PasswordCheck)
            {
                OnRegistrationFailed("Passwords do not match.");
                Password = PasswordCheck = "";
                return;
            }
            
            using (var db = new DatabaseContext())
            {
                if (db.Users.FirstOrDefault(x => x.Login == Login) == null)
                {
                    var user = new User() { Name = Name, Login = Login, Password = Password };
                    db.Users.Add(user);
                    db.SaveChanges();
                    OnRegistrationSucced();
                    return;
                }
            }
            OnRegistrationFailed("This login is already exist. Choose another one.");
            Password = PasswordCheck = "";
        }
    }
}
