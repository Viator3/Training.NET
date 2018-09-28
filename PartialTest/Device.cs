using System;

namespace PartialTest
{
    public partial class Device
    {
        partial void Video();
        partial void Game();

        public void Maid()
        {
            Console.WriteLine("I know how to call ...");
            Video();
            Game();
        }
    }
}
