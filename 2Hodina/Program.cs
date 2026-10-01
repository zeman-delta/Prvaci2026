namespace _2Hodina;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadej 1. cislo:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej 2. cislo:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("zadej operaci:");
        char operace = char.Parse(Console.ReadLine());
        
        double c;
        
        if (operace == '+')
        {
            c = a + b;
        } 
        else if (operace == '-')
        {
            c = a - b;
        }
        else
        {
            c = 0;
            Console.WriteLine("zadána neplatná operace.");
        }

        Console.WriteLine($"Součet je {c}");
    }
}