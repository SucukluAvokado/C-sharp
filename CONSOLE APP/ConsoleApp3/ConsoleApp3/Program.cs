internal class Program
{
    private static void Main(string[] args)
    {
        int en, boy, yukseklik;
        int d_oranı;


        en = Convert.ToInt32(Console.ReadLine());
        boy = Convert.ToInt32(Console.ReadLine());
        yukseklik = Convert.ToInt32(Console.ReadLine());


        int havuz = en * boy * yukseklik;
        Console.WriteLine(havuz + "m3");
    }
}