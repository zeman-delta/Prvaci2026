namespace _21_Switch;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        int mesic = rnd.Next(1,13);

        switch (mesic)
        {
            case 1:
                Console.WriteLine("Leden");
                break;
            
            case 2:
                Console.WriteLine("Únor");
                break;
            
            case 3:
                Console.WriteLine("Březen");
                break;

            case 4:
                Console.WriteLine("Duben");
                break;

            case 5:
                Console.WriteLine("Květen");
                break;

            case 6:
                Console.WriteLine("Červen");
                break;

            case 7:
                Console.WriteLine("Červenec");
                break;

            case 8:
                Console.WriteLine("Srpen");
                break;

            case 9:
                Console.WriteLine("Září");
                break;

            case 10:
                Console.WriteLine("Říjen");
                break;

            case 11:
                Console.WriteLine("Listopad");
                break;

            case 12:
                Console.WriteLine("Prosinec");
                break;

        }

        switch (mesic)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Má 31 dní");
                break;
            
            case 2:
                Console.WriteLine("Má 28/29 dní");
                break;
            
            default:
                Console.WriteLine("Má 30 dní");
                break;
        }

        Console.ReadKey();
    }
}