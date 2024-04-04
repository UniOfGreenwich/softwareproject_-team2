using System;
using System.Windows;

namespace libarysystem_WpfApp
{
    public partial class LateStudentPayment : Window
    {
        public LateStudentPayment()
        {
            InitializeComponent();
        }

        private void PayNowButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve input values from the fields
            string studentID = txtStudentID.Text;
            string bookTitle = txtBookTitle.Text;
            DateTime purchaseDate = dpPurchaseDate.SelectedDate ?? DateTime.Now; // Use current date if no date selected
            string isbn = txtISBN.Text;
            double bookPrice;

            // Validate and parse book price
            if (!double.TryParse(txtBookPrice.Text, out bookPrice))
            {
                MessageBox.Show("Please enter a valid book price.", "Payment Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Calculate late payment fee
            DateTime currentDate = DateTime.Now;
            TimeSpan lateDays = currentDate.Subtract(purchaseDate);
            double lateFee = 0.10 * lateDays.TotalDays * bookPrice; // 10 pence per day

            // Payment processing logic
            // For demonstration purposes, we assume any card number with 8 digits is valid
            string paymentMethod = "Credit Card"; // For example, the user selects credit card payment
            Random random = new Random();
            string cardNumber = random.Next(10000000, 99999999).ToString();

            if (cardNumber.Length == 8)
            {
                MessageBox.Show("Payment Successful", "Payment Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Payment Failed", "Payment Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
