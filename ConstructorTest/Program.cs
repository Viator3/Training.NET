using System;

    //Create a class.
    //In the class, create a constructor with several fields.
    //Create 10 different instances of the class.

namespace ConstructorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Base[] catalog = new Base[10];
            for (int index = 0; index < catalog.Length; index++)
            {
                catalog[index] = new Base("Name" + index, catalog.Length - index);
            }

            foreach (Base exemplar in catalog)
            {
                Console.WriteLine("{0} - {1}", exemplar.name, exemplar.number);
            }

            Console.ReadKey();
        }
    }
}
