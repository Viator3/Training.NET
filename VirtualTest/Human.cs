using System;

namespace VirtualTest
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Payment()
        {
            Console.WriteLine("I'm a Human, I get paid...");
        }
    }

    class Student : Human
    {
        public override void Payment()
        {
            Console.WriteLine("I'm a Student, I receive a scholarship...");
        }
    }

    class Teacher : Human
    {
        public override void Payment()
        {
            Console.WriteLine("I'm a Teacher, I receive the salary...");
        }
    }
}
