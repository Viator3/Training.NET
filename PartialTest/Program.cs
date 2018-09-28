using System;

//Create a partial class.
//Create a partial method.
//Implement this method in another part of the partial class.

namespace PartialTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device();

            device.Maid();

            Console.ReadKey();
        }
    }
}
