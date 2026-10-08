namespace _3Hodina;

public class Uloha3
{
    public static void Uloha()
    {
        Console.WriteLine("zadej cilo 1.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("zadej cilo 2.");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"A je větší a má hodnotu {a}");
        } 
        else if (b > a)
        {
            Console.WriteLine($"B je větší a má hodnotu {b}");
        }
        else
        {
            Console.WriteLine($"čísla jsou stejné a mají hodnotu {a}");
        }
    }
}