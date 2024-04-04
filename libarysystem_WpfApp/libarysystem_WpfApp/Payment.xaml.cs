using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace libarysystem_WpfApp
{
    public partial class Payment : Window
    {
        public Payment()
        {
           InitializeComponent();
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            //retrieve card details entered by the user
            string cardNumber = txtCardNumber.Text;
            string name = txtName.Text;
            string expirationDate = txtExpirationDate.Text;
            string cvv = txtCVV.Text;

        
            if (ValidateCardDetails(cardNumber, name, cvv, expirationDate)) {
                MessageBox.Show("Payment successful!", "Payment");  // if card details are valid, it shows success message and set DialogResult to true
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Invalid card details. Please try again.", "Error");
                this.DialogResult = false;
            }
        }

        //function to validate card details, it's not a sophisticated one, it's been made just for a simulation 
        private bool ValidateCardDetails(string cardNumber, string name, string cvv, string expirationDate)
        {
            if (cardNumber.Length < 13 || cvv.Length < 3)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            DateTime expDate;
            if (!DateTime.TryParse(expirationDate, out expDate) || expDate < DateTime.Now)
            {
                return false;
            }
            return true; 

        }


    }
}
