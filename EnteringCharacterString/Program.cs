using System;

//Enter a string from the keyboard, display the first and last occurrence in the string,
//as well as the total number of the character "a".

namespace EnteringCharacterString
{
    class Program
    {
        static void Main(string[] args)
        {
            int countA = 0;
            Console.Write("Enter the string: ");
            string line = Console.ReadLine();

            foreach (char symbol in line)
            {
                if (symbol == 'a') countA++;
            }

            Console.WriteLine($"The first occurrence of the symbol \"a\": {line.IndexOf('a')},\nthe last occurrence of the symbol \"a\": {line.LastIndexOf('a')},\n" +
                              $"the total \"a\" in the line: {countA}");
            Console.ReadKey();
        }
    }
}
