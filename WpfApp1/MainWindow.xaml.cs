using Microsoft.SqlServer.Server;
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


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            Test.Navigate(new PageAdd());
        }

        private void btnBank_Click(object sender, RoutedEventArgs e)
        {
             Environment.Exit(0);
            // юзать необходимо, т.к. если без него, то в диспечере задач он остается. Да он так работает, такова жизнь.
        }

        private void btnFaq_Click(object sender, RoutedEventArgs e)
        {
            //Test.NavigationService.Navigate(new FAQ());
            FAQ myFAQ = new FAQ();
            this.Hide();
            myFAQ.ShowDialog();
            this.Show();
        }

        private void frmMain_Navigated(object sender, NavigationEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test.NavigationService.Navigate(new PageAdd());
            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Test.NavigationService.Navigate(new PageAddList());
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Test.NavigationService.Navigate(new FAQ());
        }

        private void MainWindow_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
    

}
