namespace _23_Opakovani;

public class Uloha14
{
    public static void Uloha()
    {
        Random rnd = new Random();
        int teplota = rnd.Next(-10, 36);
        int pocasi = rnd.Next(0, 3);

        string pocasiText = "";
        switch (pocasi)
        {
            case 0:
                pocasiText = "slunecno";
                break;
            case 1:
                pocasiText = "dest";
                break;
            case 2:
                pocasiText = "snih";
                break;
        }
        Console.WriteLine($"Predpoved: {teplota} °C, {pocasiText}");

        if (pocasi == 2 && teplota > 5)
        {
            Console.WriteLine("Divne pocasi!");
        }
        else if (pocasi == 2 || teplota < 0)
        {
            Console.WriteLine("Vezmi si zimni bundu, cepici a rukavice.");
        }
        else if (pocasi == 1)
        {
            Console.WriteLine("Vezmi si destnik nebo plastenku.");
        }
        else if (teplota >= 25)
        {
            Console.WriteLine("Staci tricko a kratasy, nezapomen na opalovaci krem.");
        }
        else if (teplota >= 15)
        {
            Console.WriteLine("Vezmi si mikinu.");
        }
        else
        {
            Console.WriteLine("Vezmi si bundu.");
        }
    }
}
