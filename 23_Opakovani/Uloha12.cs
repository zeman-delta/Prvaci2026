namespace _23_Opakovani;

public class Uloha12
{
    public static void Uloha()
    {
        Random rnd = new Random();
        int tajne = rnd.Next(1, 11);

        Console.WriteLine("Myslim si cislo od 1 do 10. Hadej!");
        int tip = int.Parse(Console.ReadLine());

        if (tip == tajne)
        {
            Console.WriteLine("Trefa!");
        }
        else if (Math.Abs(tip - tajne) == 1)
        {
            Console.WriteLine($"Tesne vedle, bylo to {tajne}.");
        }
        else
        {
            Console.WriteLine($"Vedle, bylo to {tajne}.");
        }
    }
}
