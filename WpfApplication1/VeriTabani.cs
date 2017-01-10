using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication1
{
    class VeriTabani
    {
        MySqlConnection baglanti;
        string hata = "";


        public DataView kayitoku(string uyekaydi)
        {
            MySqlCommand komut = new MySqlCommand("SELECT * FROM " + uyekaydi, baglanti);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adabtor.Fill(tablo);
            return tablo.AsDataView();
        }
        public void kullaniciekle(string ad, string soyad, string nick, int sifre)
        {
            MySqlCommand komut = new MySqlCommand("INSERT INTO uyekaydi (ad,soyad,nick,sifre) VALUES ('" + ad + "','" + soyad + "','" + nick + "','"+sifre+"')", baglanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
        }

        internal void kullaniciekle(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        public VeriTabani(string ipadres, string portno,string nick,string sifre,string uyekaydi)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=uyekaydi;Uid=root;Pwd=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
            try
            {
                baglanti.Open();
            }
            catch (MySqlException e)
            {
                hata = e.Message;
            }
        }
    }
}
