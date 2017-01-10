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
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for kayit.xaml
    /// </summary>
    public partial class kayit : Page
    {
        VeriTabani veri = new VeriTabani("192.168.1.1", "3306", "Hasan", "hsn", "uyekaydi");
        public MainWindow anaEkran;
        public kayit()
        {
            InitializeComponent();
            dg1.ItemsSource = "";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            anaEkran.ekran.Navigate(new giris());
        }

    }
}
