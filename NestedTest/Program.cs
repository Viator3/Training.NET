using System;

//Create a class.
//Create a nested class.
//Use nested class methods.

namespace NestedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone.Touch touch = new SmartPhone.Touch();

            touch.TurningOn();
            touch.TurningOff();

            //SmartPhone smartPhone = new SmartPhone();
            //smartPhone.TouchOn();
            //smartPhone.TouchOff();

            Console.ReadKey();
        }
    }
}
