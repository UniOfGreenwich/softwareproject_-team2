using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.OleDb;

namespace libarysystem_WpfApp
{
    public partial class IssueBook : Window
    {
        private Dictionary<string, int> BookQuantities = new Dictionary<string, int>();
        private string[] AcademicBooks = { "Mathematics", "Engineering", "English", "Business" };

        // OleDb objects declaration
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nr1227e\OneDrive - University of Greenwich\librarysystem_WpfAppH.accdb");
        OleDbCommand command;
        OleDbDataReader dr;

        public IssueBook()
        {
            InitializeComponent();
            LoadBooks();
        }

        // Load books into ComboBox when window is loaded
        private void LoadBooks()
        {
            cmbBooks.ItemsSource = AcademicBooks;
        }

        // Search button click event handler
        private void SearchBooksButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedBook = cmbBooks.SelectedItem.ToString();

            if (BookQuantities.ContainsKey(selectedBook))
            {
                int quantity = BookQuantities[selectedBook];
                if (quantity > 0)
                {
                    MessageBox.Show($"There are {quantity} copies of '{selectedBook}' available in the library.");
                }
                else
                {
                    MessageBox.Show("Sorry, book unavailable.");
                }
            }
        }

        // Load book quantities for selected book
        private void CmbBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedBook = cmbBooks.SelectedItem.ToString();
            int quantity = GetRandomQuantity();
            BookQuantities[selectedBook] = quantity;
        }

        // Generate random quantity for selected book (1-10)
        private int GetRandomQuantity()
        {
            Random rand = new Random();
            return rand.Next(1, 11);
        }

        // Payment button click event handler
        private void btnPayLateFee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Book released under staff authorization.");
            // Staff can assign the book to a student using the student's ID here
        }
    }
}
