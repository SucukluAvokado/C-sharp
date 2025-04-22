internal class Program
{
    private static void Main(string[] args)
    {
        Math.Max(5, 10);
        Math.Min(5, 10);
        Math.Sqrt(64);
        Math.Abs(-4.7);
        Math.Round(9.99);

        Console.WriteLine(Math.Max(5, 10)); //İki sayıdan büyük olanını alır
        Console.WriteLine(Math.Min(5, 10)); //İki sayıdan küçük olanını alır
        Console.WriteLine(Math.Sqrt(64));   //Sayıyının kare kökünü alır
        Console.WriteLine(Math.Abs(-4.7));  //Sayıyı pozitife çevirir
        Console.WriteLine(Math.Round(9.99));//Bir sayıyı en yakın tam sayıya yuvarlaR
    }
}