using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ubeydahmet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen tekrar bir sayı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            for (int sayac = 1; sayac <= sayi2; sayac++)
            {
                sonuc = sonuc * sayi1;
            }
            Console.WriteLine(sonuc.ToString());
        }
    }
}
