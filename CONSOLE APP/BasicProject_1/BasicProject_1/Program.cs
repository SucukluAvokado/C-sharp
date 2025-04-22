using BasicProject_1;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Ogrenci ogrenci1 =new Ogrenci ("Yunus","Yaşa","Cerrahpaşa",100,100,100,169);

        Console.WriteLine("1.2.3");
        int a=Convert.ToInt32(Console.ReadLine());

        


        if (a == 1)
        {
            ogrenci1.ogrenciBiligileriniGoster();
        }
        else if (a == 2) 
        {
            int ogrort =ogrenci1.ogrenciOrtalamasiBul();
            Console.WriteLine(ogrort);
        }
        else if (a == 3)
        {
            ogrenci1.okUlIsmi();
        }
    }
} 