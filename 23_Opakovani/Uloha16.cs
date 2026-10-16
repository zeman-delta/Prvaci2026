namespace _23_Opakovani;

public class Uloha16
{
    public static void Uloha()
    {
        Random rnd = new Random();
        int zustatek = rnd.Next(0, 5001);

        Console.WriteLine($"Zustatek na uctu: {zustatek} Kc");
        Console.WriteLine("Kolik chces vybrat?");
        int castka = int.Parse(Console.ReadLine());

        if (castka <= 0)
        {
            Console.WriteLine("Zamitnuto: castka musi byt kladna.");
        }
        else if (castka % 100 != 0)
        {
            Console.WriteLine("Zamitnuto: castka musi byt delitelna 100.");
        }
        else if (castka > zustatek)
        {
            Console.WriteLine("Zamitnuto: nedostatek penez na uctu.");
        }
        else
        {
            zustatek = zustatek - castka;
            Console.WriteLine($"Vybrano {castka} Kc. Novy zustatek je {zustatek} Kc.");
        }
    }
}
