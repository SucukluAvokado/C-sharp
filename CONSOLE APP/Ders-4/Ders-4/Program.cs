using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik.aciklama();
            Matematik mat = new Matematik();
            int toplma = mat.toplam(9, 3);
            Console.WriteLine(toplma);
            Matematik.bolme(8, 0);

            Console.ReadLine();
        }
    }
}
