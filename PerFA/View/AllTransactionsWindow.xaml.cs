using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PerFA.ViewModel;

namespace PerFA.View
{
    /// <summary>
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class AllTransactionsWindow : Window
    {
        private readonly int userId;

        public AllTransactionsWindow(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var vm = e.NewValue as VMAllTransactions;

            if (vm == null)
            {
                throw new Exception("Wrong DataContext");
            }

            vm.LoadTransactions(userId);

            if (vm.CreateTransactionWindowAction == null)
            {
                vm.CreateTransactionWindowAction = (x, y) =>
                {
                    Hide();
                    var transactionWindow = new TransactionWindow(x, y);
                    transactionWindow.Closed += (o, args) => Show();
                    transactionWindow.Show();
                };
            }
        }
    }
}
