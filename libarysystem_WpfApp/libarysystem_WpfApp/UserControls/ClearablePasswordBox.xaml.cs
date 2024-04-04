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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace libarysystem_WpfApp.UserControls
{
    /// <summary>
    /// Interaction logic for ClearablePasswordBox.xaml
    /// </summary>
    public partial class ClearablePasswordBox : UserControl
    {
        public ClearablePasswordBox()
        {
            InitializeComponent();
        }

        private string textBound;

        public string TextBound
        {
            get { return textBound; }
            set
            {
                textBound = value;
                textHolder.Text = textBound;
            }
        }

        private void btnClear(object sender, RoutedEventArgs e)
        {
            password.Clear();
            password.Focus();
        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(password.Password))
            {
                textHolder.Visibility = Visibility.Visible;
            }
            else
            {
                textHolder.Visibility = Visibility.Hidden;
            }
        }
    }
}
