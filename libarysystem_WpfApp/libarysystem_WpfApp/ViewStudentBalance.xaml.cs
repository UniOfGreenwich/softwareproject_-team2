using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

    public partial class ViewStudentBalance : Window
    {
        private decimal studentFee;
        private int StudentID;
        private string studentName;

        private Dictionary<int, decimal> Students = new Dictionary<int, decimal>();
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nr1227e\OneDrive - University of Greenwich\librarysystem_WpfAppH.accdb");
        OleDbCommand command;
        OleDbDataReader dr;
        public ViewStudentBalance(int StudentID)
        {
            InitializeComponent();
            this.StudentID = StudentID;
            LoadStudentData();
            DisplayStudentName();

        }
        private void LoadStudentData()
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT OustandingFee FROM Students WHERE StudentID=@StudentID";
                command = new OleDbCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@StudentID", StudentID);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    studentFee = Convert.ToDecimal(dr[0]);
                    Students[StudentID] = studentFee;

                    SlblStudentID.Content = $"Student ID:  {StudentID}";
                    SlblOustandingFee.Content = $"Outstanding fee:  £{studentFee:F2}";
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
        private void DisplayStudentName()
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT Name FROM Students WHERE studentID=@StudentID";
                command = new OleDbCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@StudentID", StudentID);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    studentName = Convert.ToString(dr[0]);
                    SlbltxtName.Content = "Student Name: " + studentName;
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
        private void btnPayLateFeeStaff_Click(object sender, RoutedEventArgs e)
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
                        UpdateDatabaseBalance(StudentID);
                        LoadStudentData();

                        MessageBox.Show($"Payment successful! Updated balance : ${studentFee}");
                    }
                }
            }
        }
        private void UpdateDatabaseBalance(int StudentID)
        {
            try
            {
                connection.Open();
                string updateQuery = "UPDATE Students SET   OustandingFee=@NewOustandingFee WHERE studentID=@StudentID";
                command = new OleDbCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@NewOutstandingFee", studentFee);
                command.Parameters.AddWithValue("@StudentID", StudentID);
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
}