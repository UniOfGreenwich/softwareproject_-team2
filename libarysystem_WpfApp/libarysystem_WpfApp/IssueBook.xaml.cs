using System;
using System.Windows;

namespace libarysystem_WpfApp
{
    public partial class IssueBook : Window
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void SearchBooksButton_Click(object sender, RoutedEventArgs e)
        {
            // List of academic books
            string[] academicBooks = {
                "Mathematics", "English", "Advanced Mathematics", "CAD", "Python for Beginners",
                "Business for Engineers", "Economics", "Technical Drawing", "Social Studies",
                "Electronic", "Digital and Embedded Systems", "Sensors and Networks", "Arduino Tutorial",
                "Computer Architectures", "Operating Systems", "Engineering Professional Skills",
                "Mobile Apps", "Design and Materials", "Soldering Tutorial", "Laws of Electricity"
            };

            // Display academic books in the combo box
            cmbBooks.ItemsSource = academicBooks;
        }

        private void CmbBooks_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (cmbBooks.SelectedItem != null)
            {
                // Simulate book details
                Random random = new Random();
                int availableQuantity = random.Next(0, 10);
                double bookPrice = random.Next(10, 50);

                string bookInfo = $"Author: Author {random.Next(1, 20)}\nISBN: {random.Next(10000000, 99999999)}\nAvailable Quantity: {availableQuantity}\nPrice: £{bookPrice}";

                // Show book details in a pop-up
                MessageBoxResult result = MessageBox.Show(bookInfo, "Book Information", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                // Proceed if user clicks OK
                if (result == MessageBoxResult.OK)
                {
                    OpenStaffVerificationPage();
                }
            }
        }

        private void OpenStaffVerificationPage()
        {
            // Open Staff Verification Page
            StaffVerificationPage staffVerificationPage = new StaffVerificationPage();
            staffVerificationPage.ShowDialog();
        }
    }
}
