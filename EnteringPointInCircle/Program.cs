using System;

//There is a circle.The coordinates of the center of the circle (0, 0).
//Enter the radius from the keyboard, enter the coordinates of the point.
//Find out whether the point is directly on the circle, in the circle or outside the circle.

namespace EnteringPointInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Enter the radius : ");
            double radius = IsDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the point with a space...");
            Console.Write("Enter the first coordinate: ");
            a = IsDouble(Console.ReadLine());
            Console.Write("Enter the second coordinate: ");
            b = IsDouble(Console.ReadLine());

            DefinitionOccurrence(radius, a, b);

            Console.ReadKey();
        }

        static public void DefinitionOccurrence(double radius, double a, double b)
        {
            Console.WriteLine(
                (radius == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) ? ("On the circle")
                    : ((radius > Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) ? ("In the circle")
                        : ("Outside the circle"))
            );
        }

        static public double IsDouble(string line)
        {
            double number;
            bool isDouble;

            isDouble = double.TryParse(line, out number);
            while (!isDouble)
            {
                Console.Write("Invalid format, the entered number must match the type of Double, repeat the input: ");
                isDouble = double.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
    }
}
