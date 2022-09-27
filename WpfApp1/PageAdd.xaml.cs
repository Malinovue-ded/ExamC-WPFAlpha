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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        public PageAdd()
        {
            InitializeComponent();
            

        }

        private void BtnService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnService_Click_1(object sender, RoutedEventArgs e)
        {
            Test.NavigationService.Navigate(new ServiceWindow());
        }

        private void Test_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
          //  Test.NavigationService.Navigate(new ());
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            Test.NavigationService.Navigate(new PageAddList());
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Test.NavigationService.Navigate(new PageAddProduct());
        }

        private void BtnWorker_Click(object sender, RoutedEventArgs e)
        {
            Test.NavigationService.Navigate(new SotrudPage());
        }

        private void BtnCompany_Click(object sender, RoutedEventArgs e)
        {
            Test.NavigationService.Navigate(new CompamyPage());
        }
    }
}
