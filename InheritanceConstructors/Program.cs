using System;

//Create three classes: Phone, Smartphone, Tablet, inherited from each other.
//In each of the classes, create a constructor that extends the constructor of the base class, in addition, 
//in each class, create methods that extend the functionality of the base class method.

namespace InheritanceConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phone:");
            Phone.Calls();

            Console.WriteLine("\nSmartphone:");
            Smartphone.Video();

            Console.WriteLine("\nTablet:");
            Tablet.Game();

            Console.ReadKey();
        }
    }
}
