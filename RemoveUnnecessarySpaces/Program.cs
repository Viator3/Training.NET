using System;

//In the line, remove all the extra spaces between the words, leaving only one space.

namespace RemoveUnnecessarySpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineInitial = "In the        line,         remove           " +
                                 "all the extra spaces between        the words, leaving         only one space.";

            string[] words = lineInitial.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string lineResult = string.Join(" ", words);

            Console.WriteLine($"Initial string: \n\"{lineInitial}\"\n");
            Console.WriteLine($"Result string: \n\"{lineResult}\"");
            Console.ReadLine();
        }
    }
}
