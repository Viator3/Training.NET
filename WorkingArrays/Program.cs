using System;

//Enter the array 3x3.
//Get an array in which the elements in the third line are equal to the sum of the elements of the first two lines.
//Display the initial and resultant array.

namespace WorkingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Initial array");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < columns; i++)
            {
                array[2, i] = array[0, i] + array[1, i];
            }

            Console.WriteLine();
            Console.WriteLine("Resulting array");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
