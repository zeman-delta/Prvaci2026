namespace _21_Random;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        int hod = rnd.Next(1,7);

        switch (hod)
        {
            case 1:
                Console.WriteLine("1");
                break;
            
            case 6:
                Console.WriteLine("6");
                break;
            
            default:
                Console.WriteLine("jiné");
                break;
        }
    }
}