using System;

//Create a User class;
//Create a class Manager inherited from the User;
//Create an Administrator class inherited from Manager;
//Determine the sign of difference, on this basis to know who is more important.

namespace InheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            User Bim = new User();
            User Cim = new Manager();
            User Dim = new Administrator();

            Console.WriteLine(Bim > Cim ? "Bim > Cim" : "Cim > Bim");
            Console.WriteLine(Bim > Dim ? "Bim > Dim" : "Dim > Bim");
            Console.WriteLine(Cim > Dim ? "Cim > Dim" : "Dim > Cim");

            Console.ReadKey();
        }
    }
}
