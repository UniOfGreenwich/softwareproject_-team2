using System.Windows;

namespace libarysystem_WpfApp
{
    public partial class StaffVerificationPage : Window
    {
        public StaffVerificationPage()
        {
            InitializeComponent();
        }

        private void ProceedButton_Click(object sender, RoutedEventArgs e)
        {
            // Check Staff ID and Password
            string staffID = txtStaffID.Text.Trim();
            string password = txtPassword.Password.Trim();

            // Validate Staff ID and Password
            if (staffID == "of1104h" && password == "h4011fo")
            {
                MessageBoxResult result = MessageBox.Show("Assign Book to Student?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                // Process based on user's choice
                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Book Successfully Assigned to Student", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    Close(); // Close Staff Verification Page
                }
            }
            else
            {
                MessageBox.Show("Invalid Staff ID or Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

