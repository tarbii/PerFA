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
using PerFA.Model.Database;

namespace PerFA.View
{
    /// <summary>
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {
        public TransactionWindow()
        {
            InitializeComponent();


            //using (var db = new DatabaseContext())
            //{
            //    var transactions = new ObservableCollection<Transaction>(db.Transactions);
            //    var binding = new Binding {Source = transactions, Mode = BindingMode.OneWay};
            //    BindingOperations.SetBinding(TransactionDataGrid, ItemsControl.ItemsSourceProperty, binding);
            //}
        }
    }
}
