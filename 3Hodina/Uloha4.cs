namespace _3Hodina;

public class Uloha4
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej body:");
        int body = int.Parse(Console.ReadLine());

        if (body >= 50)
        {
            Console.WriteLine("Splnil jsi.");
        }
        else
        {
            Console.WriteLine("Nepoveldo se, zkus to znovu.");
        }
    }
}