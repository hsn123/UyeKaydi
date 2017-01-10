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
        MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database = uyekaydi; Uid =root; Pwd=;");
        
        
        

        public MainWindow anaEkran;
        public kayit()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            
            baglanti.Open();
            MySqlCommand uyekaydi = new MySqlCommand("INSERT INTO uyekaydi(ad,soyad,nick,sifre) values('" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + Convert.ToString(txt4.Password) + "')", baglanti);
            uyekaydi.ExecuteNonQuery();
            uyekaydi.Dispose();
            baglanti.Close();
            MessageBox.Show("üye kaydı yapıldı");

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/giris.xaml", UriKind.Relative));
        }
    }
}
