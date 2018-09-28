using System;

namespace SolidDipTest
{
    class Phone : IMessenger
    {
        public void SendSms()
        {
            Console.WriteLine("The device is blocked, to unlock, send SMS to number: *333# ...");
        }

        virtual public void SendMessenger()
        {
            Console.WriteLine("Phone pop-up message: ");
            SendSms();
        }
    }

    class SmartPhone : Phone, IEmail
    {
        public override void SendMessenger()
        {
            Console.WriteLine("\nSmartPhone pop-up message : ");
            SendSms();
            SendEmail();
        }

        public void SendEmail()
        {
            Console.WriteLine("Or send email to e-mail: 333@gmail.com...");
        }
    }
}
