namespace _3Hodina;

public class Uloha1
{
    public static void Uloha()
    {
        Console.WriteLine("zadej cilo 1.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("zadej cilo 2.");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"obvod je {2 * (a + b)}");
    }
}