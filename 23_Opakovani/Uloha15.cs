namespace _23_Opakovani;

public class Uloha15
{
    public static void Uloha()
    {
        Console.WriteLine("Zeptej se kouzelne osmicky:");
        string otazka = Console.ReadLine();

        if (string.IsNullOrEmpty(otazka))
        {
            Console.WriteLine("Nezeptal ses!");
            return;
        }

        Random rnd = new Random();
        int odpoved = rnd.Next(1, 9);

        switch (odpoved)
        {
            case 1:
                Console.WriteLine("Urcite ano");
                break;
            case 2:
                Console.WriteLine("Rozhodne ne");
                break;
            case 3:
                Console.WriteLine("Spis ano");
                break;
            case 4:
                Console.WriteLine("Spis ne");
                break;
            case 5:
                Console.WriteLine("Zeptej se pozdeji");
                break;
            case 6:
                Console.WriteLine("Na to radsi neodpovim");
                break;
            case 7:
                Console.WriteLine("Hvezdy tomu preji");
                break;
            case 8:
                Console.WriteLine("Vubec s tim nepocitej");
                break;
        }
    }
}
