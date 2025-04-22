using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Ders_4
{
   internal class Matematik
   {
      public static void aciklama()
      {
            Console.WriteLine("Bu sınıfta matematik işlemleri yapılcak la işte");
      }
      public int toplam(int sayi1,int sayi2)
      {
            return (sayi1+sayi2);
      }
        public static int bolme(int sayi1,int sayi2)
        {
            try
            {
                return (sayi1 / sayi2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu" + ex);
                return 0;
            }
            finally
            {
                Console.WriteLine("try catch çalıştı");
            }
        }
   }
}
