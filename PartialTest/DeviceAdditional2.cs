using System;

namespace PartialTest
{
    public partial class Device
    {
        partial void Game()
        {
            Console.WriteLine("I have many games ...");
        }
    }
}
