using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace libarysystem_WpfApp
{
    public partial class RentBook : Window
    {
        private Dictionary<string, int> booksInventory = new Dictionary<string, int>();

        public RentBook()
        {
            InitializeComponent();
            InitializeBooksInventory();
        }

        private void InitializeBooksInventory()
        {
            // Initialize the inventory with 20 academic books with 10 copies each
            Random rnd = new Random();
            string[] bookGenres = { "Mathematics", "Engineering", "English", "Business" };

            foreach (var genre in bookGenres)
            {
                for (int i = 1; i <= 10; i++)
                {
                    string bookTitle = $"Book {genre} {i}";
                    booksInventory.Add(bookTitle, rnd.Next(1, 11)); // Random quantity between 1 and 10
                }
            }

            // Display the book titles in the combo box
            cmbBooks.ItemsSource = booksInventory.Keys;
        }

        private void SearchBooksButton_Click(object sender, RoutedEventArgs e)
        {
            // Display book details when search button is clicked
            string selectedBook = cmbBooks.SelectedItem as string;

            if (selectedBook != null)
            {
                int quantity = booksInventory[selectedBook];
                if (quantity > 0)
                {
                    // Show book details
                    ShowBookDetails(selectedBook, quantity);
                }
                else
                {
                    MessageBox.Show("Sorry, book unavailable");
                }
            }
            else
            {
                MessageBox.Show("Please select a book");
            }
        }

        private void ShowBookDetails(string bookTitle, int quantity)
        {
            // Display book details and payment options
            MessageBox.Show($"Book Title: {bookTitle}\nQuantity Left: {quantity}");

            // Simulate payment options
            if (quantity > 0)
            {
                bool paymentSuccess = SimulatePayment();
                if (paymentSuccess)
                {
                    MessageBox.Show("Payment successful");
                }
                else
                {
                    MessageBox.Show("Payment failed");
                }
            }
        }

        private bool SimulatePayment()
        {
            // Simulate payment with random credit card numbers
            Random rnd = new Random();
            string cardNumber = rnd.Next(10000000, 99999999).ToString(); // 8-digit card number
            bool paymentSuccess = cardNumber.Length == 8; // Payment success if card number has 8 digits
            return paymentSuccess;
        }

        private void CmbBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Display book image when book selection changes
            string selectedBook = cmbBooks.SelectedItem as string;
            if (selectedBook != null)
            {
                // Load book image based on book title (assuming image paths are stored accordingly)
                string imagePath = $"Images/{selectedBook}.jpg"; // Assuming images are stored in a folder named "Images"
                BitmapImage bitmap = new BitmapImage(new Uri(imagePath, UriKind.Relative));
                imgBook.Source = bitmap;
            }
        }

        private void PayNowButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to balance management window
            BalanceManagement balanceManagementWindow = new BalanceManagement();
            balanceManagementWindow.Show();
            this.Close();
        }

        private void PayLaterButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the current window
            this.Close();
        }
    }
}
