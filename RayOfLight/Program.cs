using System;

//The program counts how many kilometers a ray of light passes in a certain time.

namespace RayOfLight
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal speedLight = 1079252848.8m;   //km/h

            Console.WriteLine("The program counts how many kilometers a ray of light passes in a certain time.");

            Console.Write("Enter the time period of interest in years: ");
            string timeEnter = Console.ReadLine();
            int timeNew = Convert.ToInt32(timeEnter);
            FindDistance(timeNew);

            /*FindDistance(1);
            FindDistance(3);
            FindDistance(5);*/

            Console.ReadKey();

            void FindDistance(int time)
            {
                decimal distance = speedLight * time * 24 * 365;
                Console.WriteLine($"Ray of light will pass {distance} km in {time} years.");
            }
        }
    }
}
