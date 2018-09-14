using System;

//Create class: Robot, with model and age fields, as well as with methods: go, add two numbers and charge ...

namespace CreateCustomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot Verder = new Robot();

            Console.WriteLine($"I'm a robot {Verder.model = "1.2"} models, I'm {Verder.age} years old.");

            Console.Write("Enter how far I go : ");
            Verder.walks(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine($"I make two numbers and get the result: {Verder.addsTwoNumbers(2, 3)}");

            Verder.charging();

            Console.ReadKey();
        }

        class Robot
        {
            public string model;
            public int age = 3;

            public void walks(int distance)
            {
                Console.WriteLine($"I was sent to {distance} kilometers");
            }

            public int addsTwoNumbers(int a, int b)
            {
                int result = a + b;
                return result;
            }

            public void charging()
            {
                Console.WriteLine("I'm on charge, do not touch me, please ...");
            }
        }
    }
}
