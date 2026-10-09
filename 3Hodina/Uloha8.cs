namespace _3Hodina;

public class Uloha8
{

    public static void Uloha()
    {
        Console.WriteLine("Zadej cislo");
        int cislo = int.Parse(Console.ReadLine());
        int zbytek = cislo % 2;

        if (zbytek == 0)
        {
            Console.WriteLine("číslo je sudé");
        }
        else
        {
            Console.WriteLine("číslo je liché");
        }
    }
    
}