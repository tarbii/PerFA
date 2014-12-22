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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var vm = e.NewValue as VMRegistration;

            if (vm == null)
            {
                throw new Exception("Wrong DataContext");
            }

            if (vm.RegistrationSucced == null)
            {
                vm.RegistrationSucced = () =>
                {
                    MessageBox.Show("Registration was successful");
                    Close();
                };
            }

            if (vm.RegistrationFailed == null)
            {
                vm.RegistrationFailed = (s) => MessageBox.Show(s);
            }
            
        }
    }
}
