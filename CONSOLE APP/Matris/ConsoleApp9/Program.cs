using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = 0;
            int[,] dizi = new int[5,5];
            int d = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a = random.Next(0,100);
                    dizi[i,j] = a;

                    Console.Write(a+" ");

                }
                Console.WriteLine("");
            }
            Console.WriteLine("Sütun sayısı giriniz");
            int sutun =Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                d += dizi[i,sutun];
                
            }
            Console.WriteLine(d);



            Console.ReadKey();
        }
    }
}
