using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace libarysystem_WpfApp
{
    public partial class CheckStudentBalance: Window
    {
        private Dictionary<int, decimal> StudentBalances = new Dictionary<int, decimal>();

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nicol\OneDrive\Documents\librarysystem_WpfApp.accdb");
        OleDbCommand command;
        OleDbDataReader dr;
        private decimal StudentBalance = 0;
        public CheckStudentBalance()
        {
            InitializeComponent();
        }

        //function for retrieving student balance based on Student ID
        private void btnVerifyStudent_Click(object sender, RoutedEventArgs e)
        {

            int StudentID = int.Parse(txtStudentID.Text); 
            if (!int.TryParse(txtStudentID.Text, out StudentID))
            {
                MessageBox.Show("Please enter a valid Student I.");
                return;
            }
            try
            {
                connection.Open();

                string selectQuery = "SELECT BalanceAmount FROM StudentBalances WHERE StudentID=@StudentID";
                command = new OleDbCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@StudentID", StudentID);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    StudentBalance = Convert.ToDecimal(dr[0]);
                    StudentBalances[StudentID] = StudentBalance; 
                    MessageBox.Show($"Student ID: ${StudentID}\nBalance:${StudentBalance}");
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

    }
}
