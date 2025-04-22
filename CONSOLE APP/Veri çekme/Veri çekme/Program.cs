using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Veri_çekme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=DB;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            string query = "SELECT * FROM Personel where Bolum = @Bolum";
            SqlCommand komut = new SqlCommand(query,baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int ProjeSayisi = (int)komut.ExecuteScalar();
            Console.WriteLine($"{Bolum} bölümüne ait proje sayısı : {ProjeSayisi}");
        }
    }
}
