using System;

/*
We make a deposit for a certain amount and time.
If the deposit is less than 1000, we say that there are not enough funds.
If the deposit is over or equal to 1000, we suggest choosing a deposit term (6, 12 or 24 months).
At 6 - 5%, at 12 - 12%, at 24 - 25%.
Calculate the amount of the receipt using the switch operator
*/

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            bool control;

            Console.Write("Enter the deposit amount: ");
            int amountDeposit = Convert.ToInt32(Console.ReadLine());
            control = (amountDeposit < 1000);

            switch (control)
            {
                case (true):
                    Console.WriteLine("Small deposit!");
                    break;
                default:
                    Console.Write("Enter the deposit period (6,12 or 24 months): ");
                    int termDeposit = Convert.ToInt32(Console.ReadLine());

                    switch (termDeposit)
                    {
                        case 6:
                            result = amountDeposit + amountDeposit * 0.05;
                            break;
                        case 12:
                            result = amountDeposit + amountDeposit * 0.12;
                            break;
                        case 24:
                            result = amountDeposit + amountDeposit * 0.25;
                            break;
                        default:
                            control = true;
                            Console.WriteLine("Invalid deposit period selected!");
                            break;
                    }

                    if (!control)
                    {
                        Console.WriteLine($"Your deposit: {amountDeposit}, You'll get: { result}");
                    }

                    break;
            }
            Console.ReadKey();
        }
    }
}
