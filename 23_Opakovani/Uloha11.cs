namespace _23_Opakovani;

public class Uloha11
{
    public static void Uloha()
    {
        Random rnd = new Random();
        int kostka1 = rnd.Next(1, 7);
        int kostka2 = rnd.Next(1, 7);

        Console.WriteLine($"Padlo {kostka1} a {kostka2}, soucet je {kostka1 + kostka2}.");

        // nejdriv nejprisnejsi podminka - dve sestky jsou zaroven dublet
        if (kostka1 == 6 && kostka2 == 6)
        {
            Console.WriteLine("Jackpot!");
        }
        else if (kostka1 == kostka2)
        {
            Console.WriteLine("Dublet!");
        }
    }
}
