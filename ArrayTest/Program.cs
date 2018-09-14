using System;

    //Enter a string from the keyboard consisting of more than 5 elements.
    //It is necessary to put the entered string character by character into an initialized array of characters consisting of only 5 elements.

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string longer than 5 characters: ");
            string line = Console.ReadLine();
            char[] arrayInitial = new char[5];

            char[] arrayLine = line.ToCharArray();
            int size = arrayLine.Length;

            Array.Resize(ref arrayInitial, size);
            Array.Copy(arrayLine, arrayInitial, size);

            Console.Write("The resulting array: ");

            foreach (char symbol in arrayInitial)
            {
                Console.Write(symbol);
            }

            Console.ReadKey();
        }
    }
}