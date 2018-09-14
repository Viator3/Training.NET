using System;

    //Create class Phonebook.
    //In the class, create various constructors, to fill not all fields.
    //Create 5 different instances of the class by filling in different fields.

namespace ConstructorRestarting
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook[] phoneBook = new PhoneBook[5];

            for (int index = 0; index < phoneBook.Length; index++)
            {
                phoneBook[index] = new PhoneBook();
            }

            phoneBook[0] = new PhoneBook("Val", 102030);
            phoneBook[1] = new PhoneBook("Dim", "@gmail", 555555);
            phoneBook[2] = new PhoneBook("Serg", "@gmail", "Kharkiv", 987654);
            phoneBook[3] = new PhoneBook("Ura", 222222);

            phoneBook[3] = new PhoneBook { name = "Andry" };

            foreach (PhoneBook phone in phoneBook)
            {
                Console.WriteLine("{0}, {1}, {2}, {3:##-##-##}", phone.name, phone.email, phone.address, phone.number);
            }

            Console.ReadKey();
        }
    }
}
