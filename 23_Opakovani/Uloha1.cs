namespace _23_Opakovani;

public class Uloha1
{
    public static void Uloha()
    {
        Console.WriteLine("Zadej svuj vek");
        int vek = int.Parse(Console.ReadLine());
        Console.WriteLine("Jsi student? (a/n)");
        bool student = bool.Parse(Console.ReadLine());

        if (vek < 6 || vek >= 65)
        {
            Console.WriteLine("Vstup mas zdarma.");
        }
        else if (student && vek < 26)
        {
            Console.WriteLine("Vstupenka stoji 90 Kc.");
        }
        else
        {
            Console.WriteLine("Vstupenka stoji 180 Kc.");
        }
    }
}
