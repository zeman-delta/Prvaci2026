namespace _23_Opakovani;

public class Uloha8
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej cislo 1.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej operator (+ - * / %)");
        string op = Console.ReadLine();
        Console.WriteLine("Zadej cislo 2.");
        double b = double.Parse(Console.ReadLine());

        switch (op)
        {
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
}
