using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    internal class Program
    {
        static void islem(int a, int b, int c)
        {
            int toplam = 0;
            if (c == 1)
            {
                toplam = a + b;
            }
            else if (c == 2)
            {
                toplam = a - b;
            }
            else if (c == 3)
            {
                toplam = a * b;
            }
            else if (c == 4)
            {
                toplam = a / b;
            }

            Console.WriteLine(toplam);
        }
        static void Main(string[] args)
        {
            islem(6, 4, 1);

            Console.ReadKey();
            
        }
    }
}


