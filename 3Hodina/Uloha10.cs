using System.Globalization;

namespace _3Hodina;

public class Uloha10
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej svuj vek");
        int vek = int.Parse(Console.ReadLine());

        int cena = 180;

        if (vek < 15 || vek > 65)
        {
            cena = 90;
        }

        Console.WriteLine($"tvá cena je {cena}");
    }
}