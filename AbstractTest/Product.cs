using System;

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
