using System;

//Create several classes of inherited from one abstract parent.
//Create an abstract method in the parent class, implement this method in the child classes.

namespace AbstractTest
{
    abstract class Product
    {
        public string Name { get; set; }
        public abstract void HowStore();
    }

    class Computer : Product
    {
        public override void HowStore()
        {
            Console.WriteLine("We store in stock...");
        }
    }

    class Chocolate : Product
    {
        public override void HowStore()
        {
            Console.WriteLine("We store in the refrigerator...");
        }
    }
}
