internal class Program
{
    static void adyazdir()
    {
        Console.WriteLine("Yunus");
    }
    static void adyazdir2(string soyad)
    {
        Console.WriteLine("Yunus"+ soyad);
    }
    static string adyazdir3(string soyad)
    {
        return ("Yunus" + soyad);
    }
    static int ToplamaIslemi(int a ,int b)
    {
        int toplam = a + b;
       return  toplam ;
    }
    static void tc(int a)
    {
        if (a % 2 == 0)
        {
             Console.WriteLine("Çifttir");
        }
        else
        {
             Console.WriteLine("Tektir");
        }
    }
    static bool ciftmi(int a) 
    {
        if (a % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
       
    }
    static void saydır(string a, char b)
    {
        int sayac = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] == b)
            {
                sayac++;
            }
        }
        Console.WriteLine("Bu kadar vardır -->" + sayac);
    }
    private static void Main(string[] args)
    {
        /*
        adyazdir();// Bu dümdüz
        adyazdir2(" Yaşa"); // Bunun değeri yukarda atanır
        Console.WriteLine(adyazdir3(" yasaa"));// Bunun değerini burda tanımlayabilir atayabiliriz.
        Console.WriteLine();
        
        Console.WriteLine("2 SAYI GİR TOPLASIN");
        int a =Convert.ToInt32(Console.ReadLine());
        int b =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ToplamaIslemi(a, b));
        
        Console.WriteLine("Sayi gir") ;
        int a = Convert.ToInt32(Console.ReadLine());
        tc(a);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Sayi gir");
        int b = Convert.ToInt32(Console.ReadLine());
        if (ciftmi(b))
        {
            Console.WriteLine("çİFTTİR".ToUpper());
        }
        else
        {
            Console.WriteLine("tEKTİR".ToUpper());
        }
        */
        //Klavyeden 1 string metin ve 1 char akrakter alıncak
        //metnin içinde o kaarakterden kaç tane olduğu bulunup programda
        //yazdıralacak.--1

        //4 işlem (2sayı arasında) yapan metot burada tek mettotta 4 işlem yapsın ama biz
        //hangisini tercih ediyorsak o çalışşsın.--2
        Console.WriteLine("Metin gir");
        string a =Console.ReadLine();
        Console.WriteLine("Harf gir");
        char b =Convert.ToChar( Console.ReadLine());

        saydır(a,b);
        
    }
}