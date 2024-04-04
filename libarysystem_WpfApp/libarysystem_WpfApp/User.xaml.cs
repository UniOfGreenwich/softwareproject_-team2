﻿using System;
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
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : Window
    {

        public string user;
        public User()
        {
            InitializeComponent();
        }

        private void StaffButton_Click(object sender, RoutedEventArgs e)
        {
            user = "staff";
            LoginPage login = new LoginPage(user);
            login.Show();
            this.Close();
            
        }

        private void StudentButton_Click(object sender, RoutedEventArgs e)
        {
            user = "student";
            LoginPage login = new LoginPage(user);
            login.Show();
            this.Close();
           
        }
    }
}
