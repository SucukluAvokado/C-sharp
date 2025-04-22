using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int en, boy, yukseklik;
            int d_oranı, d_oranı2;

            Console.WriteLine("En'i giriniz");
            en = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyu gir");
            boy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yükseklik la gardeş");
            yukseklik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Doluluk yüzde olarak oranını giriniz");
            d_oranı = Convert.ToInt32(Console.ReadLine());

            int havuz = en * boy * yukseklik;
            Console.WriteLine(havuz + "m3");
            Console.WriteLine("---------------------------------");

            d_oranı2 = (havuz * d_oranı) / 100;
            Console.WriteLine(d_oranı2 +"m3 kadar suya ihtiyaç vardır");

            
          
            Console.ReadKey();

        }
    }
}
