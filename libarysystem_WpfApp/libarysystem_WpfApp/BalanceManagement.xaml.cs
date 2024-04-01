using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using Window = System.Windows.Window;
using System.Data.OleDb;


namespace libarysystem_WpfApp
{
    public partial class BalanceManagement : Window

    {
        private decimal studentBalance = 0;  //Initiating the student balance

        private Dictionary<int, decimal> StudentBalances = new Dictionary<int, decimal>();

        private int loggedInUserId = 2; //This would be set when the user logs in


        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nicol\OneDrive\Documents\librarysystem_WpfApp.accdb");
        OleDbCommand command;
        OleDbDataReader dr;
        public BalanceManagement()
        {
            InitializeComponent();
            // loggedInUserId = GetLoggedInUserId();   private int GetLoggedInUserId() needs to be implemented here, so that it can retrieve the user ID from the authentication system, would return a hardcoded user ID
            UpdateBalanceDisplay();
        }
        private void UpdateBalanceDisplay()
        {
            //int studentID = int.Parse(txtStudentID.Text); // Assuming txtStudentID is the TextBox where the student enters their ID.
            //if (!int.TryParse(txtStudentID.Text, out studentID)) {
            //    MessageBox.Show("Please enter a valid Student I.");
            //        return;
            //}
            try
            {
                connection.Open();

                string selectQuery = "SELECT BalanceAmount FROM StudentBalances WHERE studentID=@ID";
                command = new OleDbCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@StduentID", loggedInUserId);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    studentBalance = Convert.ToDecimal(dr[0]);
                    StudentBalances[loggedInUserId] = studentBalance; //Update or add the balance
                                                                      // MessageBox.Show($"Your current balance: ${studentBalance}"); //Display student balanc
                    lblBalance.Content = $"${studentBalance}";
                }
                else
                {
                    MessageBox.Show("Student not found or balance is unavailable.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving balance: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private void PayLateFee(decimal amount)
        {

            // Prompt the user for card details
            string cardNumber = PromptForCardNumber();
            string cvv = PromptForCVV(cardNumber);

            // Validate the card details
            if (!ValidateCardDetails(cardNumber, cvv))
            {
                MessageBox.Show("Invalid card details. Please try again.");
                return;
            }

            // Process the payment
            bool paymentSuccessful = ProcessPayment(cardNumber, cvv, amount);

            if (paymentSuccessful)
            {
                // Update the balance in the database
                UpdateBalanceInDatabase(loggedInUserId, -amount);

                // Send a confirmation message to the student user
                SendConfirmationMessage(loggedInUserId, amount);
            }
            else
            {
                MessageBox.Show("Payment failed. Please try again.");
            }
        }

        private string PromptForCardNumber()
        {
            // Implement this method to prompt the user for their card number
            Console.Write("Please enter your card number: ");
            string cardNumber = Console.ReadLine();
            return cardNumber;
        }

        private string PromptForCVV(string cardNumber)
        {
            // Implement this method to prompt the user for their CVV
            // The prompt should be for a 3-digit CVV for Visa and debit cards
            // and a 4-digit CVV for Amex cards
            // Determine the card type based on the card number
            string cardType = GetCardType(cardNumber);
            string cvv;
            if (cardType == "Amex")
            {
                // For Amex cards, prompt for a 4-digit CVV
                Console.Write("Please enter your 4-digit CVV: ");
                cvv = Console.ReadLine();
            }
            else
            {
                // For Visa and debit cards, prompt for a 3-digit CVV
                Console.Write("Please enter your 3-digit CVV: ");
                cvv = Console.ReadLine();
            }

            return cvv;
        }

        private string GetCardType(string cardNumber)
        {
            // Implement this method to determine the card type based on the card number
            // This could involve checking the first few digits of the card number

            // Remove any spaces or dashes in the card number
            cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            // Check the first digit of the card number
            switch (cardNumber[0])
            {
                case '3':
                    // Amex card numbers start with '3'
                    return "Amex";
                case '4':
                    // Visa card numbers start with '4'
                    return "Visa";
                case '5':
                    // Mastercard card numbers start with '5'
                    return "Mastercard";
                case '6':
                    // Discover card numbers start with '6'
                    return "Discover";
                default:
                    // Unknown card type
                    return "Unknown";
            }
        }

        private bool ValidateCardDetails(string cardNumber, string cvv)
        {
            // Determine the card type based on the card number
            string cardType = GetCardType(cardNumber);

            // Check the length of the card number and CVV based on the card type
            if (cardType == "Amex")
            {
                // Amex card numbers should be 15 digits and CVVs should be 4 digits
                if (cardNumber.Length != 15 || cvv.Length != 4)
                {
                    return false;
                }
            }
            else
            {
                // Visa, Mastercard, and Discover card numbers should be 16 digits and CVVs should be 3 digits
                if (cardNumber.Length != 16 || cvv.Length != 3)
                {
                    return false;
                }
            }

            // Check that the card number and CVV only contain digits
            if (!cardNumber.All(char.IsDigit) || !cvv.All(char.IsDigit))
            {
                return false;
            }

            // If all checks pass, the card details are valid
            return true;


            // Implement this method to validate the card details
            // This could involve checking the card number and CVV format,
            // checking that the card number and CVV match, etc.
        }

        private bool ProcessPayment(string cardNumber, string cvv, decimal amount)
        {
            // Simulate a delay for the payment process
            System.Threading.Thread.Sleep(2000);

            // In a real-world application, you would interact with a payment gateway here
            // to process the payment. You would send the card number, CVV, and amount to the
            // payment gateway and receive a response indicating whether the payment was successful.

            // For this example, we'll simulate a successful payment by always returning true.
            return true;
            // Implement this method to process the payment
            // This would involve interacting with the payment gateway
        }

        private void UpdateBalanceInDatabase(int userId, decimal amount)
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Create the SQL query to update the balance
                string updateQuery = "UPDATE StudentBalances SET BalanceAmount = BalanceAmount + @Amount WHERE StudentID = @ID";

                // Create the command with the query and the connection
                command = new OleDbCommand(updateQuery, connection);

                // Add the parameters
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@ID", userId);

                // Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the update
                MessageBox.Show($"Error updating balance: {ex.Message}");
            }
            finally
            {
                // Always close the connection, even if an error occurs
                connection.Close();
            }
            // Implement this method to update the balance in the database
        }
    }



        private void btnCheckBalance_Click(object sender, RoutedEventArgs e)
        {
            UpdateBalanceDisplay() ;
        }

        private void btnPayOutstandingBalance_Click(object sender, EventArgs e)
            {
            //Prompt user for payment amount
            decimal paymentAmount;
            if (decimal.TryParse(txtPaymentAmount.Text, out paymentAmount))
                {
                //Asking user if wants to proceed with payments
                var result=MessageBox.Show($"Confirm payment of ${paymentAmount}?", "Payment Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    //Payment process here and update the balance in database
                   

                    studentBalance -= paymentAmount; //Deducting payment from balance
                    MessageBox.Show($"Payment successful! Updated balance : ${studentBalance}");
                }
                else
                {
                    MessageBox.Show("Payment canceled.");
                }
            }else
            {
                MessageBox.Show("Invalid payment amount. Please enter a valid number.");
            }
        }
     
    }
}