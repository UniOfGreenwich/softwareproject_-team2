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
using System.Data.OleDb;

namespace libarysystem_WpfApp
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent(); 
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void clearableSearchBox_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void StudentManagementButton_Click(object sender, RoutedEventArgs e)
        {
            BalanceManagement balanceManagement = new BalanceManagement();
            balanceManagement.Show();
            this.Close();
        }
        private void StudentRentBookButton_Click(object Sender, RoutedEventArgs e) { 
            RentBook rentBook = new RentBook();
            rentBook.Show();
            this.Close();

        }
    }
}
