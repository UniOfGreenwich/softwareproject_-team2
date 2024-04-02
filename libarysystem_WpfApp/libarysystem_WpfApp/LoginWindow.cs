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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginBT_Click(object sender, RoutedEventArgs e)
        {

        }
        class Program
        {
            static void LoginWindow (string[] args)
            {
                // Dummy data for student and staff accounts
                string[] studentAccounts = { "zp9906d@gre.ac.uk", "aa4759n@gre.ac.uk", "sp0675d@gre.ac.uk", "of1104h@gre.ac.uk", "nr1227e@gre.ac.uk" };
                string[] staffAccounts = { "staff1@gre.ac.uk", "staff2@gre.ac.uk", "staff3@gre.ac.uk", "staff4@gre.ac.uk", "staff5@gre.ac.uk" };

                Console.WriteLine("Welcome to Library System");
                Console.WriteLine("Please login:");

                // Input email
                Console.Write("Email: ");
                string email = Console.ReadLine();

                // Validate email format
                if (!IsValidEmail(email))
                {
                    Console.WriteLine("Invalid email format. Please enter a valid email in the format 'username@gre.ac.uk'.");
                    return;
                }

                // Input password
                Console.Write("Password: ");
                string password = Console.ReadLine();

                // Check if email and password match student accounts
                if (Array.Exists(studentAccounts, element => element == email) && IsValidPassword(password))
                {
                    Console.WriteLine("Login successful! Welcome, student.");
                    // Proceed with student actions
                }
                // Check if email and password match staff accounts
                else if (Array.Exists(staffAccounts, element => element == email) && IsValidPassword(password))
                {
                    Console.WriteLine("Login successful! Welcome, staff.");
                    // Proceed with staff actions
                }
                else
                {
                    Console.WriteLine("Login failed. Incorrect email or password.");
                }
            }

            // Function to validate email format
            static bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email && email.EndsWith("@gre.ac.uk");
                }
                catch
                {
                    return false;
                }
            }

            // Function to validate password (just checking if it's not empty for simplicity)
            static bool IsValidPassword(string password)
            {
                return !string.IsNullOrEmpty(password);
            }
        }
    }
}




