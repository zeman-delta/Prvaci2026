using System.Globalization;

namespace _3Hodina;

public class Uloha11
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej pocet minut.");
        int minuty = int.Parse(Console.ReadLine());

        int hodiny = minuty / 60;
        minuty = minuty % 60;

        if (minuty <= 4)
        {
            Console.WriteLine($"{hodiny} hodina {minuty} minuty");
        }
        else
        {
            Console.WriteLine($"{hodiny} hodina {minuty} minut"); // alternativně: hodiny + " hodina " + minuty + " minut"
        }
    }
}