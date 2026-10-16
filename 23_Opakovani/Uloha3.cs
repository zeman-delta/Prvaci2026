namespace _23_Opakovani;

public class Uloha3
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej stranu a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej stranu b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej stranu c");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Trojuhelnik je rovnostranny.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Trojuhelnik je rovnoramenny.");
            }
            else
            {
                Console.WriteLine("Trojuhelnik je obecny.");
            }
        }
        else
        {
            Console.WriteLine("Z techto stran trojuhelnik sestrojit nejde.");
        }
    }
}
