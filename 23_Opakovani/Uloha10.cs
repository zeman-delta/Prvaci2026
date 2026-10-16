namespace _23_Opakovani;

public class Uloha10
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej nazev mesice (napr. leden)");
        string mesic = Console.ReadLine().ToLower();

        switch (mesic)
        {
            case "prosinec":
            case "leden":
            case "unor":
                Console.WriteLine("Je zima.");
                break;
            case "brezen":
            case "duben":
            case "kveten":
                Console.WriteLine("Je jaro.");
                break;
            case "cerven":
            case "cervenec":
            case "srpen":
                Console.WriteLine("Je leto.");
                break;
            case "zari":
            case "rijen":
            case "listopad":
                Console.WriteLine("Je podzim.");
                break;
            default:
                Console.WriteLine("Takovy mesic neznam.");
                break;
        }
    }
}
