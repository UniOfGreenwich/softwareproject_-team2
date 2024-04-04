using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
<<<<<<< HEAD
=======
//using Finisar.SQLite;
>>>>>>> 009816d68ac0f46e9071f70af8745aa1dd0b1c73
using libarysystem_WpfApp.UserControls;

namespace libarysystem_WpfApp
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        string[] studentUsername = { "aa4759n@gre.ac.uk", "sp1234@gre.ac.uk", "nc2345@gre.ac.uk", "ob9876@gre.ac.uk", "zl4657@gre.ac.uk" };
        string[] studentPassword = { "sunday@1", "sniper@2", "monday@3", "friday@4", "leader@5" };
        string[] staffUsername = { "aa4760n@gre.ac.uk", "sp1234@gre.ac.uk", "nc2345@gre.ac.uk", "ob9876@gre.ac.uk", "zl4657@gre.ac.uk" };
        string[] staffPassword = { "monday@1", "sniper@2", "monday@3", "friday@4", "leader@5" };

        private string user;
        public LoginPage(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();

           
            string enteredUsername = Username.username.Text;
          
            string enteredPassword = Password.password.Password;

            bool studentFound = false;
            bool staffFound = false;

           
            if (user == "student")
            {
                for (int i = 0; i < studentUsername.Length; i++)
                {
                    if (studentUsername[i] == enteredUsername && studentPassword[i] == enteredPassword)
                    {
                        studentFound = true;
                        break;
                    }
                }
            }
            
            if (user == "staff")
            {
                for (int i = 0; i < staffUsername.Length; i++)
                {
                    if (staffUsername[i] == enteredUsername && staffPassword[i] == enteredPassword)
                    {
                        staffFound = true;
                        break;
                    }
                }
            }


            if (staffFound) 
            {
                StaffHomepage homepage = new StaffHomepage();
                homepage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
            
        }
    }
}
