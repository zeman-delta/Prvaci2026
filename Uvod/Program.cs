namespace Uvod;

class Program
{
    static void Main(string[] args)
    {
        int[] pole = new int[30];

        for (int i = 0; i < pole.Length; i++)
        {
            Random rnd = new Random();
            
            pole[i] = rnd.Next(20, 101);
        }

        
        int soucet = 0;

        for (int i = 0; i < pole.Length; i++)
        {
            Console.Write(pole[i] + "; ");
            soucet = soucet + pole[i];
        }

        Console.WriteLine();
        Console.WriteLine(soucet);


        Console.WriteLine("Toto" + " je " + "nas " + "vysledek" + '8');
        Console.WriteLine("Toto je nas vysledek");
        
    }
}