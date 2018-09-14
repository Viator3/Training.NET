using System;

namespace GetSetTest
{
    class Root
    {
        private double a;
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double b;
        public double B => b = 12;
        
        public double C { get; set; } = 36;

        public int D { get; set; }

        public double X { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public int SolutionQuadraticEquation(double a, double b, double c)
        {
            D = (int)(Math.Pow(b, 2) - 4 * a * c);
            return D;
        }

        public double SolutionQuadraticEquation(double a, double b)
        {
            X = -b / (2 * a);
            return X;
        }

        public void SolutionQuadraticEquation()
        {
            Console.WriteLine("There is no solution.");
        }

        public double[] SolutionQuadraticEquation(double a, double b, int d)
        {
            X1 = (-b + Math.Sqrt(d)) / (2 * a);
            X2 = (-b - Math.Sqrt(D)) / (2 * a);
            return new[] { X1, X2 };
        }
    }
}
