using System;

//Enter the number, calculate the factorial of the entered number.
//For example:
//4! = 1 * 2 * 3 * 4;

namespace CalculatingFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double factorial = 1;
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int index = number; index > 0; index--)
            {
                factorial *= index;
            }

            Console.WriteLine($"The factorial of the number {number} is {factorial}.");
            Console.ReadLine();
        }
    }
}

