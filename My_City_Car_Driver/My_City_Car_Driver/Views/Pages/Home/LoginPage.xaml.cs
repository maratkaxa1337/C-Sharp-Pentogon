using My_City_Car_Driver.Models;
using My_City_Car_Driver.Views.Pages.ViewDataPages;
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

namespace My_City_Car_Driver.Views.Pages.Home
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var currentUser = ContextConnect.db.Signin.FirstOrDefault(item => item.Username == txbUsername.Text &&
                item.Password == psdPassword.Password);
                if (currentUser == null)
                    MessageBox.Show("Вы ввели неверные данные авторизации! Пожалуйста, повторите попытку...", "Не верно",
                        MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
                else 
                { 
                    switch(currentUser.IDRole)
                    {
                        case "A":
                            MessageBox.Show("Привет Администратор" + currentUser.Username);
                            NavigationService.Navigate(new UserViewData());
                            break;
                        case "U":
                            MessageBox.Show("Привет Пользователь" + currentUser.Username);
                            break;
                            
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + "выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }

        }
    }
}
