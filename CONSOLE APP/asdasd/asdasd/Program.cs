internal class Program
{
    private static void Main(string[] args)
    {
        string metin = Console.ReadLine();
        string[] kelimeler = metin.Split(' ');
        string sonuc = "";
        for (int i = 0; i < kelimeler.Length; i++)
        {
            string ilkHarf = kelimeler[i].Substring(0, 1);
            string sonrakiHarfler = kelimeler[i].Substring(1);
            string duzgun = ilkHarf.ToUpper() + sonrakiHarfler.ToLower();
            sonuc += duzgun + " ";
        }
        
        Console.WriteLine(sonuc); // "Bu Bir Örnek Metindir"
    }
}