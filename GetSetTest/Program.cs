using System;

    //Solve the quadratic equation.
    //To create a class, the class fields must be private access modifiers, for the solution to use one method, but taking the various parameters.

namespace GetSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Root exemplar = new Root();

            exemplar.A = 1;

            exemplar.D = exemplar.SolutionQuadraticEquation(exemplar.A, exemplar.B, exemplar.C);

            Console.WriteLine("Discriminant = {0}", exemplar.D);

            if (exemplar.D == 0)
            {
                Console.WriteLine("The root x = {0}", exemplar.SolutionQuadraticEquation(exemplar.A, exemplar.B));
            }
            else
            {
                if (exemplar.D < 0)
                {
                    exemplar.SolutionQuadraticEquation();
                }
                else
                {
                    Console.WriteLine("The roots x1 = {0} and x2 = {1};",
                        exemplar.SolutionQuadraticEquation(exemplar.A, exemplar.B, exemplar.D)[0], exemplar.SolutionQuadraticEquation(exemplar.A, exemplar.B, exemplar.D)[1]
                    );
                }
            }

            Console.ReadKey();
        }
    }
}
