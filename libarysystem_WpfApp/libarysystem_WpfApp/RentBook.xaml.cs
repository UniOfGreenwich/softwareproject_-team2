using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
<<<<<<< HEAD
using System.Windows.Media.Imaging;
=======
>>>>>>> phase/3-Ali-Abdullah786

namespace libarysystem_WpfApp
{
    public partial class RentBook : Window
    {
<<<<<<< HEAD
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
=======
        public RentBook()
        {
            InitializeComponent();
>>>>>>> phase/3-Ali-Abdullah786
        }

        private void SearchBooksButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> phase/3-Ali-Abdullah786
        }

        private void CmbBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> phase/3-Ali-Abdullah786
    }
}
