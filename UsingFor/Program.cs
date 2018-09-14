using System;

//Enter two numbers from the keyboard, the first less than the second.
//Output from each line the numbers between the entered, and the number of equal to the same number.
//For example, if you enter 2 and 5, the output should be:
//22
//333
//4444
//55555

namespace UsingFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number greater than the first: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (; a <= b; a++)
            {
                for (int index = 0; index < a; index++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
