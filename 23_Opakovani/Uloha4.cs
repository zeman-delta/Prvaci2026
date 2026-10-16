namespace _23_Opakovani;

public class Uloha4
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej cislo dne v tydnu (1-7)");
        int den = int.Parse(Console.ReadLine());

        // s negaci: "neni sobota ani nedele"
        if (!(den == 6 || den == 7))
        {
            Console.WriteLine("Do skoly!");
        }
        else
        {
            Console.WriteLine("Hura, vikend!");
        }

        // bez negace - stejny vysledek (De Morgan: !(A || B) je totez co !A && !B)
        if (den != 6 && den != 7)
        {
            Console.WriteLine("Do skoly!");
        }
        else
        {
            Console.WriteLine("Hura, vikend!");
        }
    }
}
