using System;
using System.Linq;

//There is an array 3 on x(the number of columns in the rows is unknown).
//Enter the array.
//Find the minimum element in the first line and the maximum in the third row.

namespace WorkingArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int columns, min, max, i = 0;
            int[][] array = new int[3][];

            foreach (int[] row in array)
            {
                Console.Write($"Enter the number of elements in {i + 1} line: ");
                columns = Convert.ToInt32(Console.ReadLine());
                array[i] = new int[columns];

                Console.WriteLine($"Enter {columns} numbers of the {i + 1} line: ");
                for (int index = 0; index < columns; index++)
                {
                    array[i][index] = Convert.ToInt32(Console.ReadLine());
                }

                i++;
            }

            min = array[0].Min();
            max = array[2].Max();

            Console.WriteLine("\nReceived array: ");
            foreach (int[] row in array)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nThe minimum number in the 1 line is {min}, the maximum number in the 3 line is {max}.");
            Console.ReadKey();
        }
    }
}
