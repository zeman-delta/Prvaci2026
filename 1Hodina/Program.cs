namespace _1Hodina;

class Program
{
    static void Main(string[] args)
    {
        // je A sudé číslo?
        
        int a = 18568;
        int b = a;
        a = 185689;

        int c = a % 2;
        String odpoved = $"Číslo je sudé (a = {a}): {c} -> {c == 0}";
        Console.WriteLine(odpoved);
        c = b % 2;
        odpoved = $"Číslo je sudé (b = {b}): {c} -> {c == 0}  {{a}}";
        Console.WriteLine(odpoved);
        
        
        
        // X Y -> vypíšu jejich součet, rozdíl, součin, podíl a zbytek.
        // Hezky to vypíšu

        int x = 10;
        int y = 15;

        int soucet = x + y;
        int rozdil = x - y;
        int soucin = x * y;
        double podil = x / (double) y;
        int zbytek = x % y;

        Console.WriteLine($"Soucet je {soucet}");
        Console.WriteLine($"Rozdil je {rozdil}");
        Console.WriteLine($"Soucin je {soucin}");
        Console.WriteLine($"Podil je {podil}");
        Console.WriteLine($"Zbytek je {zbytek}");
        

        Console.Write($"Soucet je {soucet}. ");
        Console.Write($"Rozdil je {rozdil}. ");
        Console.Write($"Soucin je {soucin}. ");
        Console.Write($"Podil je {podil}. ");
        Console.Write($"Zbytek je {zbytek}. ");
        
        // Jmeno (string)
        // prijmeni (string)
        // Obor (string)
        // Věk (int)
        // Ročník (int) 
        // třída (char)
        // plnoletý (bool)
        Console.WriteLine("\n");

        Console.WriteLine("Zadej své jméno: ");
        string jmeno = Console.ReadLine();
        Console.WriteLine("Zadej své příjmení: ");
        string prijmeni = Console.ReadLine();
        Console.WriteLine("Co studuješ za obor? ");
        string obor = Console.ReadLine();
        Console.WriteLine("Kolik ti je let? ");
        int vek = int.Parse(Console.ReadLine());
        Console.WriteLine("V jakém jsi ročníku? ");
        int rocnik = int.Parse(Console.ReadLine());
        Console.WriteLine("V jaké jsi třídě? (A, B, ...) ");
        char trida = Console.ReadKey().KeyChar; // Char.Parse(Console.ReadLine())
        Console.WriteLine("Jsi plnoletý?");
        bool plnolety = vek >= 18; // bool.Parse(Console.ReadLine())


        Console.WriteLine(
            $"Student se jmenuje {jmeno} {prijmeni}, studuje obor {obor}" +
            $" je mu {vek} (plnoletý: {plnolety}) a aktuálně je v {rocnik}." +
            $" ročníku (třída {trida})."
        );
    }
}