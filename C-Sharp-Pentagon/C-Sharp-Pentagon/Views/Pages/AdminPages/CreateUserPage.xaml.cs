﻿using C_Sharp_Pentagon.Context;
using C_Sharp_Pentagon.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C_Sharp_Pentagon.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для CreateUserPage.xaml
    /// </summary>
    public partial class CreateUserPage : Page
    {
        public CreateUserPage()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                User newUser = new User();
                newUser.Username = txbUsername.Text;
                newUser.Password = txbPassword.Text;
                newUser.IDRole = "U";
                ContextConnect.db.User.Add(newUser);
                ContextConnect.db.SaveChanges();
                MessageBox.Show("Новый пользователь успешно создан!", "Уведомление системы!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source + " выдал исключение.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
