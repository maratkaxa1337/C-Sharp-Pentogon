using My_City_Car_Driver.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace My_City_Car_Driver.Views.Pages.ViewDataPages
{
    /// <summary>
    /// Interaction logic for UserViewData.xaml
    /// </summary>
    public partial class UserViewData : Page
    {
        public UserViewData()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = DbContext.db.product.ToList();
        }
    }
}
