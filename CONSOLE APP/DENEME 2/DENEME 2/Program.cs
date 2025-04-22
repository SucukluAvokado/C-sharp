using System.Data;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {

        for (int i = 1; i <= 6; i++)
        {
            for (int j = 6; j > i; j--) 
            {
                Console.Write(" ");
            }

            for (int y = 1; y <= i ; y++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
      
       





    }


    }
