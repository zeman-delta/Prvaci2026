namespace _23_Opakovani;

public class Uloha6
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej cislo");
        double cislo = double.Parse(Console.ReadLine());

        if (cislo >= 10 && cislo <= 20)
        {
            Console.WriteLine("Cislo lezi v intervalu <10; 20>.");
        }
        else
        {
            Console.WriteLine("Cislo nelezi v intervalu <10; 20>.");
        }

        // s negaci
        if (!(cislo >= -5 && cislo <= 5))
        {
            Console.WriteLine("Cislo lezi mimo interval <-5; 5>.");
        }

        // bez negace
        if (cislo < -5 || cislo > 5)
        {
            Console.WriteLine("Cislo lezi mimo interval <-5; 5>.");
        }
    }
}
