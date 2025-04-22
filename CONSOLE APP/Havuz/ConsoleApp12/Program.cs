using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int en,boy,yuksekilk;
            

            
            Console.WriteLine("en = ");
            en = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("boy = ");
            boy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yukseklik = ");
            yuksekilk = Convert.ToInt32(Console.ReadLine());

            int toplam = en * boy * yuksekilk;
            Console.WriteLine("Havuzun toplam hacmi ="+toplam);

            Console.WriteLine("Havuz yüzde kaç doludur ? ---> %");
            int yuzde = Convert.ToInt32(Console.ReadLine());

            int hesap = (toplam * yuzde) / 100;

            Console.WriteLine("Havuzun dolması için "+hesap+"m3 kadar suya ihtiyaç vardır");
            Console.ReadLine();
        }
    }
}
