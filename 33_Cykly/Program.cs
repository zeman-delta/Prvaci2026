namespace _33_Cykly;

class Program
{
    static void Main(string[] args)
    {
        /*
        while (true)
        {
            Console.WriteLine("Zadej svuj vek");
            int vek = int.Parse(Console.ReadLine());
            
            if (vek < 0)
            {
                break;
            }
            
            Console.WriteLine("Jsi student? (a/n)");
            bool student = bool.Parse(Console.ReadLine());
            
            
            if (vek < 6 || vek >= 65)
            {
                Console.WriteLine("Vstup mas zdarma.");
            }
            else if (student && vek < 26)
            {
                Console.WriteLine("Vstupenka stoji 90 Kc.");
            }
            else
            {
                Console.WriteLine("Vstupenka stoji 180 Kc.");
            }
        }
        */

        /*
        bool pokracovat = true;
        
        while (pokracovat)
        {
            Console.WriteLine("Zadej cislo 1.");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej operator (+ - * / %)");
            string op = Console.ReadLine();
            Console.WriteLine("Zadej cislo 2.");
            double b = double.Parse(Console.ReadLine());

            if (op == "end")
            {
                break;
            }

            switch (op)
            {
                case "end":
                    pokracovat = false;
                    break;
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Nulou delit nejde.");
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    }
                    break;
                case "%":
                    if (b == 0)
                    {
                        Console.WriteLine("Nulou delit nejde.");
                    }
                    else
                    {
                        Console.WriteLine($"{a} % {b} = {a % b}");
                    }
                    break;
                default:
                    Console.WriteLine("Neznamy operator");
                    break;
            }
        }
        */

        Random rnd = new Random();
        Console.WriteLine("Stiskni Enter pro vygenerování čísla.");

        while (true)
        {
            Console.ReadLine();

            int hod;
            int soucet = 0;
            
            do
            {
                hod = rnd.Next(1, 7);
                soucet += hod;

                if (soucet == 18)
                {
                    break;
                }
            } 
            while (hod == 6);

            if (soucet == 18)
            {
                Console.WriteLine($"Hodil jsi: {soucet}, jdeš na distanc!!");
            }
            else
            {
                Console.WriteLine($"Hodil jsi: {soucet}");
            }
            
        }

    }
}