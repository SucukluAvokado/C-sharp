using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {

        static void sırla(int[] dizi)
        {

            int gecici;
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = i; j < dizi.Length; j++)
                {
                    
                    if (dizi[i] > dizi[j])
                    {
                        gecici = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = gecici;
                    }
                }
            }
            
        }
        static void medyan(int[] dizi)
        {

            if (dizi.Length % 2 != 0)
            {
                int a = dizi[dizi.Length/2];
                Console.WriteLine("medyan " + a);
            }
            else
            {
                int a = dizi[dizi.Length / 2 - 1];
                int b = dizi[dizi.Length / 2 ];
                int toplam = a + b;
                Console.WriteLine("medyan" + toplam/2);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] dizi1 = new int[rnd.Next(1,11)] ;
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = rnd.Next(0, 100);
            }
            

            sırla (dizi1);

            Console.WriteLine();
            Console.Write("Dizinin son hali: ");
            foreach (int deger in dizi1)
            {
                Console.Write(deger + " ");
            }

            medyan(dizi1);

            Console.ReadLine();
        }
    }
}
    


