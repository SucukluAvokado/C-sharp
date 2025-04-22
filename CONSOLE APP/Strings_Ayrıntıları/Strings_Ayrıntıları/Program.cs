using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
       //Metnin uzunluğunun verir
        string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine("The length of the txt string is: " + txt.Length);

      //Metnin tamamını küçük veya büyük yapar
        string txt = "Hello World";
        Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
        Console.WriteLine(txt.ToLower());   // Outputs "hello world"

      //string.Concat()Bu yöntemi iki dizeyi birleştirmek için de kullanabilirsiniz :
        string firstName = "John ";
        string lastName = "Doe";
        string name = string.Concat(firstName, lastName);
        Console.WriteLine(name);

      //Dize birleştirmenin başka bir seçeneği de değişkenlerin değerlerini bir dizedeki yer tutucularla değiştiren
      //dize enterpolasyonudur . Birleştirmede olduğu gibi boşluklar konusunda endişelenmenize gerek olmadığını unutmayın:(NOT ÖNEMLİ)
        string firstName = "John";
        string lastName = "Doe";
        string name = $"My full name is: {firstName} {lastName}";
        Console.WriteLine(name);

       //SUBSTİNG VE INDEXOF
       // Başka bir yararlı yöntem Substring(), belirtilen karakter konumundan / dizinden başlayarak bir dizedeki karakterleri çıkaran 
       //ve yeni bir dize döndüren yöntemdir.IndexOf()Bu yöntem genellikle belirli bir karakter konumunu elde etmek için ile birlikte kullanılır:
        // Full name
        string name = "John Doe";

        // Location of the letter D
        int charPos = name.IndexOf("D");

        // Get last name
        string lastName = name.Substring(charPos);

        // Print the result
        Console.WriteLine(lastName);

       //EXTRA ARAÇLAR
        \n New Line
        \t Tab	
        \b Backspace
    }
}