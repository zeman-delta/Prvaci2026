namespace _3Hodina;

public class Uloha6 {

    public static void Uloha()
    {
        Console.Write("zadej teplotu: ");
        double teplotaC = Convert.ToDouble(Console.ReadLine()); // double.Parse()

        double teplotaF = teplotaC * 1.8 + 32;

        Console.WriteLine($"Výsledek je {teplotaF}");
    }

}