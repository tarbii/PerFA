using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using PerFA.Model;

namespace PerFA.View
{
    public sealed class UserToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var user = value as User;

            return user == null ? "<error>" : String.Format("{0} ({1})", user.Name, user.Login);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
