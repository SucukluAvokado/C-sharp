using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ders4._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlBaglanti sqlBaglanti = new SqlBaglanti();
            //Bağlantı
            sqlBaglanti.baglan("THE-HUNTER\\SQLEXPRESS","DB");
            sqlBaglanti.baglantiac();
            /*
            string conntectionString = "Server =THE-HUNTER\\SQLEXPRESS;Database=DB;Trusted_Connection=True";
            SqlConnection baglanti = new SqlConnection(conntectionString);
            baglanti.Open();
            */
            //Sorgu ile veri çekme olayı
           
            
            //SqlCommand cmd = new SqlCommand(query,baglanti);
            SqlDataReader reader = sqlBaglanti.sorguCalistir("select * from Personel");
            

            while (reader.Read()) 
            {
                string ad = reader.GetString(1);
                int dogumyeri = reader.GetInt32(3);
                int ücret = Convert.ToInt32(reader[4]);

                Console.WriteLine("Ad: " + ad);
                Console.WriteLine("Doğum Yeri: " + dogumyeri);
                Console.WriteLine("Ücret: " + ücret);
                Console.WriteLine("----------------");
            }
            reader.Close();
            sqlBaglanti.baglantikapa();
            
            
              
         Console.ReadLine();
        }
    }
}
