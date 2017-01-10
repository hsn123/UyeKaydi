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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for resimler.xaml
    /// </summary>
    public partial class resimler : Page
    {
        
       

        public resimler()
        {
            InitializeComponent();
            
        }

        private void kaydet_Click(object sender, RoutedEventArgs e)
        {
            string[] isimler;

            isimler = bilgi.Text.Split();

            for (int i = 0; i < isimler.Length; i++)

            {

                lst1.Items.Add(isimler[i]);

            }
           
        }
    }
}
