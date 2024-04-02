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

        private decimal studentFee;
        private string studentName;

        private Dictionary<int, decimal> Students = new Dictionary<int, decimal>();
        private int loggedInUserId = 3;

        // OleDb objects declaration
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nr1227e\OneDrive - University of Greenwich\librarysystem_WpfAppH.accdb");
        OleDbCommand command;
        OleDbDataReader dr;


        public BalanceManagement()
        {
            InitializeComponent();
            DisplayOutstandingFee();
            DisplayStudentIDName();
        }


        // function to display outstanding fee
        private void DisplayOutstandingFee()
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT OustandingFee FROM Students WHERE studentID=@StudentID";
                command = new OleDbCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@StudentID", loggedInUserId);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    studentFee = Convert.ToDecimal(dr[0]);
                    Students[loggedInUserId] = studentFee;
                    lblOustandingFee.Content = $"Outstanding Fee: ${studentFee:F2}";
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
            finally // close connection
            {
                connection.Close();
            }

        }
        private void DisplayStudentIDName()
        {
            lblStudentID.Content = "Student ID: " + loggedInUserId;
            try
            {
                connection.Open();
                string selectQuery = "SELECT Name FROM Students WHERE studentID=@StudentID";
                command = new OleDbCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@StudentID", loggedInUserId);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    studentName = Convert.ToString(dr[0]);
                    lbltxtName.Content = "Student Name: " + studentName;
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving student name: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private void UpdateDatabaseBalance(int loggedInUserId)
        {
            try
            {
                connection.Open();
                string updateQuery = "UPDATE Students SET   OustandingFee=@NewOustandingFee WHERE studentID=@StudentID";
                command = new OleDbCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@NewOutstandingFee", studentFee);
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

        // function for paying late fee button click
        private void btnPayLateFee_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = 0;
            if (decimal.TryParse(
            Microsoft.VisualBasic.Interaction.InputBox("Enter the amount to pay:", "Add Balance"), out amount))
            {
                var result = MessageBox.Show($"Add ${amount} ?", "Confirm Payment", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Payment paymentWindow = new Payment();
                    if (paymentWindow.ShowDialog() == true) //Show and execute functions from payment window 
                    {
                        studentFee += amount;
                        UpdateDatabaseBalance(loggedInUserId);
                        DisplayOutstandingFee();
                        MessageBox.Show($"Payment successful! Updated balance : ${studentFee}");
                    }
                }
            }
        }
    }
}
