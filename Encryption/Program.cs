using System;

//Enter a string, encrypt it with XOR.
//Decrypt and display.

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Enter a string, encrypt it with XOR.";
            string lineEncrypt = "", lineDecrypt = "";
            char key = 'f';


            foreach (char symbol in line)
            {
                char symbolEncrypt = Convert.ToChar(symbol ^ key);
                lineEncrypt += symbolEncrypt;
            }

            foreach (char symbol in lineEncrypt)
            {
                char symbolDecrypt = Convert.ToChar(symbol ^ key);
                lineDecrypt += symbolDecrypt;
            }

            Console.WriteLine($"The original string: {line}");
            Console.WriteLine($"Encrypted string: {lineEncrypt}");
            Console.WriteLine($"Decrypted string: {lineDecrypt}");
            Console.ReadKey();
        }
    }
}

