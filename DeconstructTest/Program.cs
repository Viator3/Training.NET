using System;

//Create a class with multiple fields.
//Applying Deconstruct get the values of the instance of the class.

namespace DeconstructTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human { Name = "Val", Age = 22 };

            (string name, int age) = human;

            Console.WriteLine("Human name = {0}, age = {1}", name, age);
            Console.ReadKey();

        }
    }
}
