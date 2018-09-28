using System;

//Create two classes of Phone and the Smartphone inherited from it.
//It is necessary, after blocking the device, to realize the possibility of receiving to the Phone only SMS,
//and to the Smartphone SMS and an e-mail with further instructions.

namespace SolidDipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            SmartPhone smartPhone = new SmartPhone();

            phone.SendMessenger();
            smartPhone.SendMessenger();

            Console.ReadKey();
        }
    }
}
