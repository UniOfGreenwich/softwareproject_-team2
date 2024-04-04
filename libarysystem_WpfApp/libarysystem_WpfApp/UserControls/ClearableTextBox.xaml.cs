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
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string boundText;

        public string BoundText
        {
            get { return boundText; }
            set
            {
                boundText = value;
                textHolder.Text = boundText;
            }
        }

        private void btnClear(object sender, RoutedEventArgs e)
        {
            username.Clear();
            username.Focus();
        }
        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
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
