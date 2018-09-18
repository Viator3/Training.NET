using System;

namespace AbstractTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Product comp = new Computer();
            Product chocolate = new Chocolate();

            Console.Write("{0}", comp.Name = "Comp - ");
            comp.HowStore();

            Console.Write("{0}", chocolate.Name = "Chocolate - ");
            chocolate.HowStore();

            Console.ReadKey();
        }
    }
}
