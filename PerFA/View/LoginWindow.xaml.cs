using System;
using System.Windows;
using PerFA.Model;
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
            var registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new AllTransactionsWindow(3).Show();
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
                    var allTransactionWindow = new AllTransactionsWindow(x);
                    allTransactionWindow.Closed += (o, args) => Show();
                    allTransactionWindow.Show();
                };
            }
        }
    }
}
