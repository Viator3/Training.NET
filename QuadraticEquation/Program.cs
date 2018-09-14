using System;

//Given a quadratic equation: A*x^2 + B*x + C = 0.
//Numbers A, B, C are entered from the keyboard.
//Find the roots of the equation.

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, D, x, x1, x2;
            Console.WriteLine("Solve the quadratic equation, enter three numbers in turn. Where A is not 0.");

            Console.Write("Enter A not equal to 0: ");
            A = DoubleCheck(Console.ReadLine(), "A");

            Console.Write("Enter B: ");
            B = DoubleCheck(Console.ReadLine(), "B");

            Console.Write("Enter C: ");
            C = DoubleCheck(Console.ReadLine(), "C");

            SolutionQuadraticEquation1(A, B, C);
            SolutionQuadraticEquation2(A, B, C);

            Console.ReadKey();


            void SolutionQuadraticEquation1(double a, double b, double c)
            {
                D = Math.Pow(b, 2) - 4 * a * c;

                string result = (D == 0) ? ($"The root x = {-b / (2 * a)}") :
                    (D < 0) ? ("There is no solution.") : ($"The roots x1 = {(-b + Math.Sqrt(D)) / (2 * a)} and x2 = {(-b - Math.Sqrt(D)) / (2 * a)};");

                Console.WriteLine(result);
            }

            void SolutionQuadraticEquation2(double a, double b, double c)
            {
                D = Math.Pow(b, 2) - 4 * a * c;

                if (D == 0)
                {
                    x = -b / (2 * a);
                    Console.WriteLine($"The root x = {x}");
                }
                else
                {
                    if (D < 0)
                    {
                        Console.WriteLine("There is no solution.");
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        Console.WriteLine($"The roots x1 = {x1} and x2 = {x2};");
                    }
                }
            }



            double DoubleCheck(string line, string coefficient)
            {
                double number;

                bool isDouble = Double.TryParse(line, out number);
                if (coefficient == "A")
                {
                    while (!isDouble || number == 0)
                    {
                        Console.WriteLine("Enter A not equal to 0: ");
                        line = Console.ReadLine();
                        isDouble = Double.TryParse(line, out number);
                    }
                }
                else
                {
                    while (!isDouble)
                    {
                        Console.WriteLine($"Enter {coefficient}: ");
                        line = Console.ReadLine();
                        isDouble = Double.TryParse(line, out number);
                    }
                }
                return number;
            }


        }
    }
}
