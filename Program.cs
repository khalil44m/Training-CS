using System;       

namespace Training_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.WriteLine(string.Join('-', args));
            Console.Write("\nPress any key to exit...\n");
            Console.ReadKey(true);
        }
    }
}
