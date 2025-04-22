using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4._1._1
{
    internal class SqlBaglanti
    {
        private SqlConnection baglanti;
        public void baglan(string server, string db)
        {
            string conntectionString = "Server="+server+";Database=" + db +";Trusted_Connection=True";
            baglanti = new SqlConnection(conntectionString);
            
        }
        public void baglantiac()
        {
            baglanti.Open();
        }
        public void baglantikapa()
        {
            baglanti.Close();
        }
        public SqlDataReader sorguCalistir(string sorgu)
        {
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            return cmd.ExecuteReader();
        }
        public SqlDataReader Adagoresorgu(string ad)
        {
            string query = ("select * from Personel where Ad='" + ad + "'");
            SqlCommand sqlCommand = new SqlCommand(query,baglanti);
                return sqlCommand.ExecuteReader();
        }
    }
}
