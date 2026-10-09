namespace _3Hodina;

public class Uloha7
{

    public static void Uloha()
    {
        Console.WriteLine("Zadej poloměr");
        double polomer = double.Parse(Console.ReadLine());

        double obvod = polomer * 2 * Math.PI;
        double obsah = polomer * polomer * Math.PI;

        Console.WriteLine($"Pro kruh o poloměru {polomer} je obvod {obvod} a obsah {obsah}");
    }
    
}