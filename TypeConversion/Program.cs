using System;

//Create a User class;
//Create a class Manager inherited from the User;
//Create an Administrator class inherited from Manager;
//Convert the User type to Administrator, and Administrator to User, using explicit or implicit.

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();

            Administrator administrator = new Administrator();
            User user = new User();
            Console.WriteLine("User access level before conversion: {0}", user.Level);

            adapter = (Adapter)administrator;
            user = (User)adapter;
            Console.WriteLine("User access level after conversion: {0}", user.Level);

            Administrator administrator2 = new Administrator();
            User user2 = new User();
            Console.WriteLine("\nAdministrator access level before conversion: {0}", administrator2.Level);

            adapter = (Adapter)user2;
            administrator2 = (Administrator)adapter;
            Console.WriteLine("Administrator access level after conversion: {0}", administrator2.Level);

            Console.ReadKey();
        }
    }
}
