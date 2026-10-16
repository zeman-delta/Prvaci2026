namespace _23_Opakovani;

public class Uloha7
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej znamku (1-5)");
        int znamka = int.Parse(Console.ReadLine());

        switch (znamka)
        {
            case 1:
                Console.WriteLine("vyborne");
                break;
            case 2:
                Console.WriteLine("chvalitebne");
                break;
            case 3:
                Console.WriteLine("dobre");
                break;
            case 4:
                Console.WriteLine("dostatecne");
                break;
            case 5:
                Console.WriteLine("nedostatecne");
                break;
            default:
                Console.WriteLine("Neplatna znamka");
                break;
        }
    }
}
