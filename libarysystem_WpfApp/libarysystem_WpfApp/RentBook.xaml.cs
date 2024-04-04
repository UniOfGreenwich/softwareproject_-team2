using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace libarysystem_WpfApp
{
    public partial class RentBook : Window
    {
        public RentBook()
        {
            InitializeComponent();
        }

        private void SearchBooksButton_Click(object sender, RoutedEventArgs e)
        {
            // List of academic books
            List<string> academicBooks = new List<string>
            {
                "Mathematics", "English", "Advanced Mathematics", "CAD", "Python for Beginners",
                "Business for Engineers", "Economics", "Technical Drawing", "Social Studies",
                "Electronic", "Digital and Embedded Systems", "Sensors and Networks", "Arduino Tutorial",
                "Computer Architectures", "Operating Systems", "Engineering Professional Skills",
                "Mobile Apps", "Design and Materials", "Soldering Tutorial", "Laws of Electricity"
            };

            // Display academic books in the combo box
            cmbBooks.ItemsSource = academicBooks;
        }

        private void CmbBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbBooks.SelectedItem != null)
            {
                // Simulate book details
                Random random = new Random();
                string bookTitle = cmbBooks.SelectedItem.ToString();
                string author = $"Author of {bookTitle}";
                string isbn = $"ISBN of {bookTitle}";
                int availableQuantity = random.Next(0, 10);
                double bookPrice = random.Next(10, 50);

                // Show book details in a pop-up
                MessageBox.Show($"Author: {author}\nISBN: {isbn}\nAvailable Quantity: {availableQuantity}\nPrice: £{bookPrice}", "Book Details");

                // Show warning when requesting book
                MessageBoxResult result = MessageBox.Show("Penalties for late return", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    // Process book request
                }
            }
        }
    }
}
