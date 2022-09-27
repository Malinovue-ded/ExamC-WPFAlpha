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
        }

        private void btnBank_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnFaq_Click(object sender, RoutedEventArgs e)
        {
            Faq af = new Faq();
            af.Owner = this;
            af.Show();
            this.Hide();
        }

        private void frmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductList af = new ProductList();
            af.Owner = this;
            af.Show();
            //MessageBox.Show("Чек");
        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            PageAddProduct af = new PageAddProduct();
            af.Owner = this;
            af.Show();
        }
    }
}
