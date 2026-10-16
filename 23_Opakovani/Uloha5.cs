namespace _23_Opakovani;

public class Uloha5
{
    public static void Uloha()
    {
        string spravneJmeno = "admin";
        string spravneHeslo = "heslo123";

        Console.WriteLine("Zadej jmeno");
        string jmeno = Console.ReadLine();
        Console.WriteLine("Zadej heslo");
        string heslo = Console.ReadLine();

        if (jmeno == spravneJmeno && heslo == spravneHeslo)
        {
            Console.WriteLine("Prihlaseno");
        }
        else if (jmeno == spravneJmeno)
        {
            Console.WriteLine("Spatne heslo");
        }
        else
        {
            Console.WriteLine("Uzivatel neexistuje");
        }
    }
}
