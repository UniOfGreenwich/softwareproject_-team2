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

namespace libarysystem_WpfApp
{
    /// <summary>
    /// Interaction logic for StaffHomepage.xaml
    /// </summary>
    public partial class StaffHomepage : Window
    {
        public StaffHomepage()
        {
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StaffIssueBookButton_Click(object sender, RoutedEventArgs e)
        {
            IssueBook issueBook= new IssueBook();
            issueBook.Show();
            this.Close();
        }
    }

}
