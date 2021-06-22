using System;

namespace communication_log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello Pilot!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello! Happy Tuesday!");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wonderful storm we're having over here!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Not much better over here");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("We'll have to wait for the weather to clear before launch then.");
            Console.ReadKey();
        }
    }
}
