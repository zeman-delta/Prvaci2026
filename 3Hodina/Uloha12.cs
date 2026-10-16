using System.Globalization;

namespace _3Hodina;

public class Uloha12
{
    
    public static void Uloha()
    {
        Console.WriteLine("Zadej kolik jsi dostal bodu");
        int body = int.Parse(Console.ReadLine());

        if (body >= 0 && body <= 100)
        {
            if (body >= 90)
            {
                Console.WriteLine("dostal jsi 1.");
            } 
            else if (body >= 75)
            {
                Console.WriteLine("dostal jsi 2.");
            }
            else if (body >= 60)
            {
                Console.WriteLine("dostal jsi 3.");
            }
            else if (body >= 50)
            {
                Console.WriteLine("dostal jsi 4.");
            }
            else
            {
                Console.WriteLine("dostal jsi 5.");
            }
        }
        else
        {
            Console.WriteLine("Zadaná neplatná hodnota");
        }
    }
    
}