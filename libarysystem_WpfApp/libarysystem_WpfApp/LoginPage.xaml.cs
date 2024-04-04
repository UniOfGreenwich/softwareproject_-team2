using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Finisar.SQLite;
using libarysystem_WpfApp.UserControls;

namespace libarysystem_WpfApp
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        string[] username = { "aa4759n@gre.ac.uk", "sp1234@gre.ac.uk", "nc2345@gre.ac.uk", "ob9876@gre.ac.uk", "zl4657@gre.ac.uk" };
        string[] password = { "sunday@1", "sniper@2", "monday@3", "friday@4", "leader@5" };
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();

        
            string enteredUsername = Username.username.Text;
          
            string enteredPassword = Password.password.Password;

            bool found = false;

            for(int i = 0; i < username.Length; i++)
            {
                if (username[i] == enteredUsername && password[i] == enteredPassword)
                {
                    found = true;
                    break;
                }
            }

            if(found) 
            {
                MessageBox.Show("Login Succesfully!");
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
            
        }
    }
}
