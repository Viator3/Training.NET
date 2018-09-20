using System;

//Create two interfaces.
//Create three classes in which to apply and implement interfaces.

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Nokia", 2, "Buttons");
            Smartphone smartphone = new Smartphone("Samsung", 5, "Touchscreen");
            Desktop desktop = new Desktop("Dell", 14, "Mouse and Keyboard");

            phone.Speaker = "Speaker";
            smartphone.Speaker = "Speaker";
            desktop.Speaker = "Loudspeakers";

            Console.WriteLine("Full information about the Phone: {0}, Diagonal: {1}", phone.Name, phone.ScreenSize);
            phone.EnteringInformation();
            phone.InformationOutput();

            Console.WriteLine("\nFull information about the Smartphone: {0}, Diagonal: {1}", smartphone.Name, smartphone.ScreenSize);
            smartphone.EnteringInformation();
            smartphone.InformationOutput();

            Console.WriteLine("\nFull information about the Desktop: {0}, Diagonal: {1}", desktop.Name, desktop.ScreenSize);
            desktop.EnteringInformation();
            desktop.InformationOutput();

            Console.ReadKey();
        }
    }
}
