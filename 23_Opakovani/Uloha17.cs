namespace _23_Opakovani;

public class Uloha17
{
    public static void Uloha()
    {
        Random rnd = new Random();
        int utokHrac = rnd.Next(1, 21);
        int obranaHrac = rnd.Next(1, 11);
        int utokNepritel = rnd.Next(1, 21);
        int obranaNepritel = rnd.Next(1, 11);

        Console.WriteLine($"Hrac:     utok {utokHrac}, obrana {obranaHrac}");
        Console.WriteLine($"Nepritel: utok {utokNepritel}, obrana {obranaNepritel}");

        // poskozeni, ktere hrac udeli nepriteli
        int poskozeniHrac = utokHrac - obranaNepritel;
        if (poskozeniHrac < 0)
        {
            poskozeniHrac = 0;
        }
        if (utokHrac == 20)
        {
            poskozeniHrac = poskozeniHrac * 2;
            Console.WriteLine("Hrac dal kriticky zasah!");
        }

        // poskozeni, ktere nepritel udeli hraci
        int poskozeniNepritel = utokNepritel - obranaHrac;
        if (poskozeniNepritel < 0)
        {
            poskozeniNepritel = 0;
        }
        if (utokNepritel == 20)
        {
            poskozeniNepritel = poskozeniNepritel * 2;
            Console.WriteLine("Nepritel dal kriticky zasah!");
        }

        Console.WriteLine($"Hrac udelil {poskozeniHrac} poskozeni, nepritel udelil {poskozeniNepritel}.");

        if (poskozeniHrac > poskozeniNepritel)
        {
            Console.WriteLine("Kolo vyhral hrac!");
        }
        else if (poskozeniNepritel > poskozeniHrac)
        {
            Console.WriteLine("Kolo vyhral nepritel!");
        }
        else
        {
            Console.WriteLine("Remiza");
        }
    }
}
