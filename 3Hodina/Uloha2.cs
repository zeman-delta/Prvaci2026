namespace _3Hodina;

public class Uloha2
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej cenu: ");
        double cena = double.Parse(Console.ReadLine());

        if (cena >= 2000)
        {
            cena = cena * 0.9;
        }

        Console.WriteLine($"Výsledná cena je {cena}");
    }
}