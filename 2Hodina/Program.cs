namespace _2Hodina;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadej 1. cislo:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej 2. cislo:");
        double b = double.Parse(Console.ReadLine());

        double c = a + b;

        Console.WriteLine($"Součet je {c}");
    }
}