namespace _23_Opakovani;

public class Uloha9
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej cislo mesice (1-12)");
        int mesic = int.Parse(Console.ReadLine());

        switch (mesic)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Mesic ma 31 dni.");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Mesic ma 30 dni.");
                break;
            case 2:
                // bonus - prestupny rok z ulohy 2
                Console.WriteLine("Zadej rok");
                int rok = int.Parse(Console.ReadLine());
                if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
                {
                    Console.WriteLine("Unor ma 29 dni.");
                }
                else
                {
                    Console.WriteLine("Unor ma 28 dni.");
                }
                break;
            default:
                Console.WriteLine("Neplatny mesic");
                break;
        }
    }
}
