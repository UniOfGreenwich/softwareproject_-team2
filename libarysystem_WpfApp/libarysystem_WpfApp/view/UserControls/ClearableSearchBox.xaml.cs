using System.Windows;
using System.Windows.Controls;

namespace libarysystem_WpfApp.view.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableSearchBox.xaml
    /// </summary>
    public partial class ClearableSearchBox : UserControl
    {
        public ClearableSearchBox()
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
            searchBook.Clear();
            searchBook.Focus();
        }
        private void searchBook_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(searchBook.Text))
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
