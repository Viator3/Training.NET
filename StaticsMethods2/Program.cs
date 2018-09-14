using System;
using System.Linq;

//Enter a real number, output it as a mirror.

namespace StaticsMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a real number: ");

            Console.WriteLine($"Mirror number: {Reverse(Console.ReadLine())}");

            Console.ReadKey();
        }

        static string Reverse(string line)
        {
            return new string(line.ToCharArray().Reverse().ToArray());
        }
    }
}
