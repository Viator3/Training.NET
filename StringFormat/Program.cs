using System;

//Different recording formats

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = 0.15345m;
            Console.WriteLine("percent number = {0:P1}", number);

            long num = 380679523545;
            string result = String.Format("{0:+# #(###)### ## ##}", num);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
