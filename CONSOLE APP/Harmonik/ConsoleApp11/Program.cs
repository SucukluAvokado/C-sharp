using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float b = 0f;
            float ort = 0f;
            float a = 0f;
            float ort2 = 0f;
            while (true)
            {
                Console.WriteLine("Sayı giriniz çıkmak için 0 a basınız.");
                a = Convert.ToInt32(Console.ReadLine());

                if (a == 0)
                {
                    break;
                }
                b++;

                ort += (1 / a);


            }
            Console.WriteLine(ort);

            ort2 = b / ort;
            Console.WriteLine("Harmonik ortalama" + ort2);
            Console.ReadLine();
        }
    }
}
