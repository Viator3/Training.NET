using System;

//Find the minimum number of two or three entered numbers(the number of entered is determined by typing from the keyboard).
//The decision is made by static methods.

namespace StaticsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter from the line of numbers we will find the minimum, from 2 or 3: ");
            int numberCount = Int32.Parse(Console.ReadLine());

            switch (numberCount)
            {
                case 2:
                    Console.WriteLine("Enter two numbers...");
                    Console.WriteLine($"Minimum number: {MinTwo(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()))}");
                    break;
                case 3:
                    Console.WriteLine("Enter three numbers...");
                    Console.WriteLine($"Minimum number: {MinThree(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()))}");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }

        static public int MinTwo(int a, int b)
        {
            return ((a < b) ? (a) : (b));
        }

        static public int MinThree(int a, int b, int c)
        {
            return ((MinTwo(a, b) < c) ? (MinTwo(a, b)) : (c));
        }
    }
}
