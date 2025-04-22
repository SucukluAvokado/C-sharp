using BasicProject_2;

internal class Program
{
    private static void Main(string[] args)
    {
        TC tc1 = new TC();

        tc1.tc = "53434276206";

        Console.WriteLine("Tc no = " + tc1.tc);

        //İF ELSE BLOĞU ÇALIŞMIYOR sayı dışında başka karakter girince else bloğuna girmiyor normal çalışmaya devam ediyor!
    }
}