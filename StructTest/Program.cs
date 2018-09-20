using System;

//Create a structure.
//Create a class in which you want to retrieve and use data from the structure.

namespace StructTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowProperties wp;
            wp.width = 60;
            wp.height = 20;

            Window win = new Window();
            win.showWindow(wp);

            Console.ReadKey();
        }
    }
}
