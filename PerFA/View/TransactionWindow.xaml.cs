using System;
using System.Collections.Generic;
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
    public partial class TransactionWindow : Window
    {
        private readonly int userId;
        private readonly int? transactionId;
        private readonly string typeOfTransaction;

        public TransactionWindow(int userId, int transactionId)
        {
            this.userId = userId;
            this.transactionId = transactionId;
            InitializeComponent();
        }

        public TransactionWindow(int userId, string typeOfTransaction)
        {
            this.userId = userId;
            this.typeOfTransaction = typeOfTransaction;
            InitializeComponent();
        }

        private void Window_DataContextChanged(object sender,
            DependencyPropertyChangedEventArgs e)
        {
            var vm = e.NewValue as VMTransaction;
            if (vm == null)
            {
                throw new Exception("Wrong DataContext");
            }

            if (transactionId != null)
            {
                vm.LoadTransaction(userId, transactionId);
            }

            else
            {
                vm.CreateTransaction(userId, typeOfTransaction);
            }

            if (vm.CloseWindowAction == null)
            {
                vm.CloseWindowAction = Close;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
