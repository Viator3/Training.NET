using System;

//Enter two numbers from the keyboard, enter * or +.
//Accordingly, either multiply or add two numbers.
//Solve the problem with the help of a ternary operator.

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired operator, * or +: ");
            string sign = Console.ReadLine();

            string result = ((sign != "*") && (sign != "+")) ? ("Invalid character") : (((sign == "*")) ? (Convert.ToString(x * y)) : (Convert.ToString(x + y)));

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}