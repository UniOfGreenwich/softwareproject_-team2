using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows;

namespace libarysystem_WpfApp
{
    public partial class LateStudentPayment : Window
    {
        private decimal lateFeePerDay = 0.10m; // 10 British pence per day

        private Dictionary<int, decimal> Students = new Dictionary<int, decimal>();
        private int loggedInUserId = 3;

        // OleDb objects declaration
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nr1227e\OneDrive - University of Greenwich\librarysystem_WpfAppH.accdb");
        OleDbCommand command;
        OleDbDataReader dr;

        public LateStudentPayment()
        {
            InitializeComponent();
        }

        private void PayNowButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the entered details
            int studentID = int.Parse(txtStudentID.Text);
            string bookTitle = txtBookTitle.Text;
            DateTime purchaseDate = dpPurchaseDate.SelectedDate ?? DateTime.Now;
            string ISBN = txtISBN.Text;
            decimal bookPrice = decimal.Parse(txtBookPrice.Text);

            // Calculate the late fee based on the difference between purchase date and current date
            int lateDays = (DateTime.Now - purchaseDate).Days;
            decimal totalLateFee = lateDays * lateFeePerDay * bookPrice;

            // Prompt for payment
            var result = MessageBox.Show($"Your late fee is £{totalLateFee:F2}. Proceed with payment?", "Confirm Payment", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                // Simulate payment success
                string paymentMethod = "Debit"; // or "Credit"
                string cardNumber = "12345678"; // Any random 8-digit number
                bool paymentSuccess = ValidatePayment(cardNumber);

                if (paymentSuccess)
                {
                    MessageBox.Show("Payment successful!");
                    // Update database with the late fee payment
                    UpdateDatabaseLateFee(studentID, totalLateFee);
                }
                else
                {
                    MessageBox.Show("Payment failed. Please try again.");
                }
            }
        }

        private bool ValidatePayment(string cardNumber)
        {
            // Simulate payment validation
            return cardNumber.Length == 8;
        }

        private void UpdateDatabaseLateFee(int studentID, decimal lateFee)
        {
            try
            {
                connection.Open();
                string updateQuery = "UPDATE Students SET LateFee=@LateFee WHERE StudentID=@StudentID";
                command = new OleDbCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@LateFee", lateFee);
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating late fee in database: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
