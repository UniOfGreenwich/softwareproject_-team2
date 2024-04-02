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
    /// Interaction logic for StudentPayment.xaml
    /// </summary>
    public partial class StudentPayment : Window
    {
        public StudentPayment()
        {
            InitializeComponent();
        }

        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            string cardNumber = cardNumberTextBox.Text;
            string expiryDate = expiryDateTextBox.Text;
            string cvv = cvvTextBox.Text;

            // Simulate payment processing
            // Replace this with actual payment processing logic using a payment gateway
            bool success = new Random().NextDouble() < 0.8; // 80% chance of success
            string message = success ? "Payment successful!" : "Payment failed. Please try again.";
            paymentMessageTextBlock.Text = message;
        }
    }
}
