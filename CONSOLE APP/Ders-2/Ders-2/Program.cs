internal class Program
{
    private static void Main(string[] args)
    {
        //Klavyeden bir metin alınsın ve harfleri yerine x yazılıp görüntülensin. - 1
       

        Console.Write("Bir metin girin: ");
        string metin = Console.ReadLine();

        string yMetin = "";
        for (int i = 0; i < metin.Length; i++)
        {
            if (Char.IsLetter(metin[i]))
            {
                yMetin += 'x';
            }
            else
            {
                yMetin += metin[i];
            }
        }

        Console.WriteLine("Yeni metin: " + yMetin);
       


        //Random oluşturulan 6*6 matrisin her satırnın toplnmını alıp ekrana yazdıran program. -2
        /*
        int[,] seri = new int[6,6];
        Random random = new Random();
        int toplam = 0;

        for (int i = 0; i < 6; i++)
        {
            toplam = 0;
            for (int j = 0; j < 6; j++)
            {
                seri[i,j]=random.Next(10);
                Console.Write(seri[i,j]+" ");
                toplam += seri[i,j];
                

            }
            Console.WriteLine();
            Console.WriteLine(i+"SATIR TOPLAMI =" + toplam);

        }
        */
    }
}