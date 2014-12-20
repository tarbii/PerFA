using System;
using System.Linq;
using System.Windows;
using PerFA.Model.Database;
using PerFA.ViewModel;

namespace PerFA.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new RegistrationWindow().ShowDialog();
        }

        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var vm = e.NewValue as VMLogin;

            if (vm == null)
            {
                throw new Exception("Wrong DataContext");
            }

            if (vm.CreateAllTransactionsWindowAction == null)
            {
                vm.CreateAllTransactionsWindowAction = x =>
                {
                    Hide();
                    new AllTransactionsWindow(x).ShowDialog();
                    Show();
                    Activate();
                    Topmost = true; 
                    Topmost = false;
                    Focus();        
                };
            }
            using (var db = new DatabaseContext())
            {
                var transactionCount = db.TransactionUsers.Count();
            }
        }
    }
}
