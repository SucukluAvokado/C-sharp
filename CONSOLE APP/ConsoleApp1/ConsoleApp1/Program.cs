using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string metin = Console.ReadLine();
        string[] kelimeler = metin.Split(' ');
        for (int i = 0; i < kelimeler.Length; i++)
        {
            kelimeler[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelimeler[i]);
        }
        string sonuc = string.Join(" ", kelimeler);
        Console.WriteLine(sonuc);
    }
}