using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
using PropertyChanged;

namespace PerFA.Model
{
    [ImplementPropertyChanged]
    class Login
    {

        public Login()
        {
            LoginMessage = "Enter your login and password to sign in.";
        }

        public string LoginMessage { get; set; }
        public string LoginData { get; set; }
        public string Password { get; set; }

        public event Action<int> LoginSucceed;

        private void OnLoginSucceed(int userId)
        {
            var handler = LoginSucceed;
            if (handler != null) handler(userId);
        }

        public void TryLogin()
        {
            using (var db = new DatabaseContext())
            {
                var user = (db.Users.Where(x => x.Login == LoginData && x.Password == Password)).FirstOrDefault();
                Password = "";
                if (user != null)
                {
                    OnLoginSucceed(user.ID);
                }
                else
                {
                    LoginMessage = "Wrong login/password";
                }
            }
        }
    }
}
