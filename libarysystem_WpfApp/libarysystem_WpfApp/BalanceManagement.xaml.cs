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
        private decimal studentBalance = 0;
        private Dictionary<int, decimal> StudentBalances = new Dictionary<int, decimal>();
        private int loggedInUserId = 2;
        decimal daysLate = 50;

        // OleDb objects declaration
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nicol\OneDrive\Documents\librarysystem_WpfApp.accdb");
        OleDbCommand command;
        OleDbDataReader dr;

        public BalanceManagement()
        {
            InitializeComponent();
            UpdateBalanceDisplay();
            DisplayOutstandingFee();

        }
        //Method to display balance update
        private void UpdateBalanceDisplay()
        {
            try
            {
                connection.Open(); //open database connection 

                string selectQuery = "SELECT BalanceAmount FROM StudentBalances WHERE studentID=@StudentID";
                command = new OleDbCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@StudentID", loggedInUserId);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    studentBalance = Convert.ToDecimal(dr[0]);
                    StudentBalances[loggedInUserId] = studentBalance;
                    lblBalance.Content = $"Balance: ${studentBalance}";
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
                connection.Close(); //close database connection
            }
        }//function to display outstandingfee
        private void DisplayOutstandingFee()
        {
            decimal lateFee = ComputeLateFee(daysLate);
            lblOustandingFee.Content = $"Outstanding Fee: ${lateFee}";
        }
        //function for adding balance
        private void btnAddBalance_Click(object sender, RoutedEventArgs e)
        {
            decimal amountToAdd;
            if (decimal.TryParse(
                Microsoft.VisualBasic.Interaction.InputBox("Enter the amount to add:", "Add Balance"),
                out amountToAdd))
            {
                var result = MessageBox.Show($"Add ${amountToAdd} to your balance?", "Confirm Payment", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Payment paymentWindow = new Payment();
                    if (paymentWindow.ShowDialog() == true)
                    {
                        studentBalance += amountToAdd;
                        UpdateDatabaseBalance(loggedInUserId);
                        UpdateBalanceDisplay();
                        MessageBox.Show($"Payment successful! Updated balance : ${studentBalance}");
                    }
                }
            }
        }
        //function to update dastabase
        private void UpdateDatabaseBalance(int loggedInUserId)
        {
            try
            {
                connection.Open();
                string updateQuery = "UPDATE StudentBalances SET BalanceAmount=@NewBalance WHERE studentID=@StudentID";
                command = new OleDbCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@NewBalance", studentBalance);
                command.Parameters.AddWithValue("@StudentID", loggedInUserId);
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

        //function to pay the late fee
        private void btnPayLateFee_Click(object sender, RoutedEventArgs e)
        {
            decimal lateFee = ComputeLateFee(daysLate);
            if (lateFee > studentBalance)
            {
                MessageBox.Show("You do not have enough balance to cover the late fee.");
            }
            else
            {
                studentBalance -= lateFee;

                MessageBox.Show("Payment successful!");

                UpdateDatabaseBalance(loggedInUserId);
                UpdateBalanceDisplay();

                daysLate = 0;
                DisplayOutstandingFee();

            }
        }
        //function to calculate the latefee
        private decimal ComputeLateFee(decimal daysLate)
        {
            return daysLate * 0.10m;
        }
    }
}