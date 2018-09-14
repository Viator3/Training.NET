using System;

//Verify that the Visual Studio environment is working.
//The program bibicates, writes the name, paints the background.

namespace Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(400, 1000);
            Console.Write("Hello! Enter you name: ");
            string name = Console.ReadLine();
            Console.Beep(500, 1000);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Beep(600, 1000);
            Console.WriteLine($"Hello, {name}!");
            Console.Beep(700, 1000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("By!");
            Console.ReadKey();
            Console.Beep(700, 1000);
        }
    }
}