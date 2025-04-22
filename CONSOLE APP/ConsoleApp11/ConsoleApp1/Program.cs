internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int b = 0;

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Sayı gir 10 tane bu "+(i+1)+". sayı");
            b = Convert.ToInt32(Console.ReadLine());
            a[i] = b;  
        }
        Console.WriteLine(a);
}
}