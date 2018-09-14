using System;

//Enter numbers from the keyboard until you press 0.
//Output the minimum and maximum values from the entered numbers.

namespace UsingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            Console.WriteLine("Start typing numbers: ");

            int number = Convert.ToInt32(Console.ReadLine());
            min = max = number;

            while (number != 0)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
                else
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }
            }

            Console.WriteLine($"min = {min}, max = {max}");
            Console.ReadKey();
        }
    }
}