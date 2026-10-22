namespace _23_Opakovani;

public class Uloha13
{
    public static void Uloha()
    {
        Random rnd = new Random();
        int pc = rnd.Next(0, 3);

        Console.WriteLine("Zvol: 0 = kamen, 1 = nuzky, 2 = papir");
        int hrac = int.Parse(Console.ReadLine());

        if (hrac < 0 || hrac > 2)
        {
            Console.WriteLine("Neplatna volba");
            return;
        }

        string pcText = "";
        switch (pc)
        {
            case 0:
                pcText = "kamen";
                break;
            case 1:
                pcText = "nuzky";
                break;
            case 2:
                pcText = "papir";
                break;
        }
        Console.WriteLine($"Pocitac zvolil: {pcText}");

        // kamen (0) porazi nuzky (1), nuzky (1) porazi papir (2), papir (2) porazi kamen (0)
        if (hrac == pc)
        {
            Console.WriteLine("Remiza");
        }
        else if ((hrac == 0 && pc == 1) || (hrac == 1 && pc == 2) || (hrac == 2 && pc == 0))
        {
            Console.WriteLine("Vyhral jsi!");
        }
        else
        {
            Console.WriteLine("Prohral jsi.");
        }
    }

    public static void Uloha1()
    {
        Random rnd = new Random();

        int pocitacCislo = rnd.Next(0, 3);
        string pocitacVolba = "";

        switch (pocitacCislo)
        {
            case 0:
                pocitacVolba = "Kamen";
                break;
            case 1:
                pocitacVolba = "Nuzky";
                break;
            case 2:
                pocitacVolba = "Papir";
                break;
        }

        Console.WriteLine("Zadej: Kamen, Nuzky, Papir");
        string uzivatelVolba = Console.ReadLine();

        if (uzivatelVolba != "Kamen" || uzivatelVolba != "Nuzky" || uzivatelVolba != "Papir") 
        {
            Console.WriteLine("neplatná volba.");
        }
        else
        {
            if (uzivatelVolba == pocitacVolba)
            {
                Console.WriteLine("remíza");
            }
            else if (
                uzivatelVolba == "Kamen" && pocitacVolba == "Nuzky"
                || uzivatelVolba == "Nuzky" && pocitacVolba == "Papir"
                || uzivatelVolba == "Papir" && pocitacVolba == "Kamen"
                )
            {
                Console.WriteLine("Vyhral uživatel");
            }
            else
            {
                Console.WriteLine("Vyhral pocitac");
            }
        }
    }
    
}
