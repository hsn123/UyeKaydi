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
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for giris.xaml
    /// </summary>
    public partial class giris : Page
    {
        
        public giris()
        {
            InitializeComponent();
        }
     
       

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string ad = txt5.Text;
            string sifre = txt6.Password;
            MySqlConnection bag = new MySqlConnection("Server = localhost; Database = uyekaydi; Uid = root; Pwd=;");
            bag.Open();
           
            MySqlCommand girisyap = new MySqlCommand("SELECT * FROM uyekaydi where nick='" + txt5.Text + " 'and sifre='" + Convert.ToString(txt6.Password) + "'", bag);
            MySqlDataReader dr = girisyap.ExecuteReader();
          
            MessageBox.Show("Hoş geldiniz (Devam Etmek İçin Tamam'a Tıklayınız.)");
          
            
            if (dr.Read())
                

            {
                
                NavigationService.Navigate(new Uri("/resimler.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Nick veya Şifre yanlış");
            }
          
            
        }
    }
}
