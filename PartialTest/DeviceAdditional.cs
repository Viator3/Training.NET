using System;

namespace PartialTest
{
    public partial class Device
    {
        partial void Video()
        {
            Console.WriteLine("I know how to shoot and show videos ...");
        }
    }
}
