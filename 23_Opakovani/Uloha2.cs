namespace _23_Opakovani;

public class Uloha2
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej rok");
        int rok = int.Parse(Console.ReadLine());

        if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
        {
            Console.WriteLine($"Rok {rok} je prestupny.");
        }
        else
        {
            Console.WriteLine($"Rok {rok} neni prestupny.");
        }
    }
}
