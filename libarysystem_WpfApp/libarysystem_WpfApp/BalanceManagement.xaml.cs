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
    public partial class BalanceManagement : Window
    {
        private decimal studentBalance = 0;  //Initiating the student balance

        private Dictionary<int, decimal> StudentBalances = new Dictionary<int, decimal>();

        private int loggedInUserId = 2; 

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nicol\OneDrive\Documents\librarysystem_WpfApp.accdb");
        OleDbCommand command;
        OleDbDataReader dr;
        public BalanceManagement()
        {
            InitializeComponent();
        
            UpdateBalanceDisplay();
        }
        private void UpdateBala
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
            /
            Console.Write("Please enter your card number: ");
            string cardNumber = Console.ReadLine();
            return cardNumber;
        }

       private string PromptForCVV(string cardNumber)
                
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
                
                if (cardNumber.Length != 16 || cvv.Length != 3)
                {
                    return false;
                }
            }

            
            if (!cardNumber.All(char.IsDigit) || !cvv.All(char.IsDigit))
            {
                return false;
            }

            
            return true;


           
        }

        private bool ProcessPayment(string cardNumber, string cvv, decimal amount)
        {
            
            System.Threading.Thread.Sleep(2000);

                     

            
            return true;
            
            
        }

        private void UpdateBalanceInDatabase(int userId, decimal amount)
        {
            try
            {
                
                connection.Open();

                
                string updateQuery = "UPDATE StudentBalances SET BalanceAmount = BalanceAmount + @Amount WHERE StudentID = @ID";

                
                command = new OleDbCommand(updateQuery, connection);

              
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@ID", userId);

                
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error updating balance: {ex.Message}");
            }
            finally
            {
                
                connection.Close();
            }
            
        }
    }



        private void btnCheckBalance_Click(object sender, RoutedEventArgs e)
        {
            UpdateBalanceDisplay() ;
        }

        private void btnPayOutstandingBalance_Click(object sender, EventArgs e)
            {
            
            decimal paymentAmount;
            if (decimal.TryParse(txtPaymentAmount.Text, out paymentAmount))
                {
                
                var result=MessageBox.Show($"Confirm payment of ${paymentAmount}?", "Payment Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    
                   

                    studentBalance -= paymentAmount; 
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
