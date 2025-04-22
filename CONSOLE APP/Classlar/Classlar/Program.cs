using Classlar;

internal class Program
{
    private static void Main(string[] args)
    {
        Araba araba1 = new Araba();

        araba1.Kapissayisi = 4;
       
        
        araba1.motorCalistir();
        araba1.kapilariKitle();

        Console.WriteLine("kapi sayisi = "+araba1.Kapissayisi);



    }
}