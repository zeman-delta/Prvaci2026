namespace _3Hodina;

public class Uloha9
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej cislo");
        double cislo = double.Parse(Console.ReadLine());

        if (cislo > 0)
        {
            Console.WriteLine("Cislo je kladne.");
        }
        else if (cislo < 0)
        {
            Console.WriteLine("Cislo je zaporne.");
        }
        else
        {
            Console.WriteLine("Cislo je nula.");
        }
    }
}