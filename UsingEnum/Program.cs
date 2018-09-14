using System;

//Enter the month.Determine the month of leave.
//To display on the screen what time of year belongs to the entered month, or this is the month of vacation.

namespace UsingEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the month of the year: ");

            Console.WriteLine(FindSeason(Console.ReadLine()));

            Console.ReadKey();
        }

        static string FindSeason(string month)
        {
            if (!Enum.TryParse(month, true, out Month m))
            {
                return "No such month...";
            }
            else
            {
                switch ((int)m)
                {
                    case 1:
                        return "Winter";
                        break;
                    case 2:
                        return "Spring";
                        break;
                    case 3:
                        return "Summer";
                        break;
                    case 4:
                        return "Autumn";
                        break;
                    default:
                        return "Holiday, Yes :)!!!";
                        break;
                }
            }
        }

        enum Month
        {
            January = 1,
            February = 1,
            March = 2,
            April = 2,
            May = 0,
            June = 3,
            July = 3,
            August = 4,
            September = 4,
            October = 4,
            November = 1,
            December = 1
        }
    }
}
