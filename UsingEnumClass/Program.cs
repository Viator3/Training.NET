using System;
using System.Linq;

    //Given an Enum of five names and five ratings.It is necessary:
    //1 - to deduce surnames and estimations of those at whom estimations> 3;
    //2 - calculate how many people have an "5" rating;
    //3 - find the minimum and maximum score;
    //4 - find the average score, deduce the names and scores of those whose scores are above the average score;
    //5 - to find how many people have an assessment above the average score;
    //6 - display the number in the order of the first person with an estimate above the average score;
    //7 - to derive the names of those who have neighboring estimates;
    //8 - for all with an estimate below the average score, re-enter the scores and then recalculate the average score.

namespace UsingEnumClass
{
    class Program
    {
        public static int Count, min, max = 0;
        public static double average = 0;

        public enum Student
        {
            Bim = 1,
            Cim = 5,
            Dim = 5,
            Fim = 2,
            Gim = 3,
        }

        static void Main(string[] args)
        {

            SurnamesWithRatingsAboveThree();
            NumberFives();
            MinMaxRatings();
            SurnamesWithRatingsAboveAverage();
            CountRatingsAboveAverage();
            FirstPersonRatingAboveAverage();
            SurnamesMatchingNeighboringEstimates();
            ReEnterRecalculateAverage();

            Console.ReadKey();
        }

        public static void SurnamesWithRatingsAboveThree()
        {
            Console.Write("Surnames with an estimate of more than three:");
            foreach (string surnames in Enum.GetNames(typeof(Student)))
            {
                int rating = (int)Enum.Parse(typeof(Student), surnames);
                if (rating > 3)
                {
                    Console.Write(" {0}", surnames);
                    Console.Write(" = {0};", rating);
                }
            }
            Console.WriteLine();
        }

        public static void NumberFives()
        {
            Count = 0;
            foreach (int rating in Enum.GetValues(typeof(Student)))
            {
                if (rating == 5)
                {
                    Count++;
                }
            }
            Console.WriteLine("Number of fives: {0}", Count);
        }

        public static void MinMaxRatings()
        {
            min = max = 0;
            foreach (int rating in Enum.GetValues(typeof(Student)))
            {
                min = Enum.GetValues(typeof(Student)).Cast<int>().Min();
                max = Enum.GetValues(typeof(Student)).Cast<int>().Max();
            }
            Console.WriteLine("Minimal rating: {0}, Maximal rating: {1}", min, max);
        }

        public static void SurnamesWithRatingsAboveAverage()
        {
            Count = 0;
            Console.Write("Surnames with an estimate of more than average:");

            foreach (string surnames in Enum.GetNames(typeof(Student)))
            {
                int rating = (int)Enum.Parse(typeof(Student), surnames);
                if (rating > Average())
                {
                    Console.Write(" {0}", surnames);
                    Console.Write(" = {0};", rating);
                }
            }
            Console.WriteLine();
        }

        public static void CountRatingsAboveAverage()
        {
            Count = 0;

            foreach (string surnames in Enum.GetNames(typeof(Student)))
            {
                int rating = (int)Enum.Parse(typeof(Student), surnames);
                if (rating > Average())
                {
                    Count++;
                }
            }
            Console.WriteLine("Number of people with an above-average rating: {0}", Count);
        }

        public static void FirstPersonRatingAboveAverage()
        {
            Count = 0;
            foreach (var fields in SortByIndex())
            {
                Count++;
                if ((int)fields > Average())
                {
                    Console.WriteLine("Number in the order of the first person with an estimate above the average ball: {0}", Count);
                    break;
                }
            }
        }

        public static void SurnamesMatchingNeighboringEstimates()
        {
            Console.Write("The names of those who have the same neighbor ratings:");
            int rating = (int)SortByIndex()[0];
            for (int index = 1; index < Enum.GetNames(typeof(Student)).Length; index++)
            {
                if (rating == (int)SortByIndex()[index])
                {
                    Console.Write(" {0}, ", SortingByAddition()[index - 1]);
                    Console.Write("{0};", SortingByAddition()[index]);
                }
                rating = (int)SortByIndex()[index];
            }
            Console.WriteLine();
        }

        public static void ReEnterRecalculateAverage()
        {
            Count = 0;
            double mean = 0;
            foreach (string surnames in Enum.GetNames(typeof(Student)))
            {
                Count++;
                int rating = (int)Enum.Parse(typeof(Student), surnames);

                if (rating < Average())
                {
                    Console.Write("{0} is below average, enter a new rating: ", surnames);
                    int change = Int32.Parse(Console.ReadLine());
                    mean += change;
                }
                else
                {
                    mean += rating;
                }
            }
            mean = mean / Count;
            Console.WriteLine("Now the average score is: {0}", mean);
        }

        public static Student[] SortByIndex()
        {
            //Student[] fieldValues = new Student[5];
            //fieldValues[0] = Student.Bim;
            //fieldValues[1] = Student.Cim;
            //fieldValues[2] = Student.Dim;
            //fieldValues[3] = Student.Fim;
            //fieldValues[4] = Student.Gim;

            var fields = typeof(Student).GetFields().Where(fi => fi.IsLiteral);
            string[] fieldNames = fields.Select(fi => fi.Name).ToArray();
            Student[] fieldValues = fields.Select(fi => fi.GetRawConstantValue()).Cast<Student>().ToArray();

            return fieldValues;
        }

        public static string[] SortingByAddition()
        {
            var fields = typeof(Student).GetFields().Where(fi => fi.IsLiteral);
            string[] fieldNames = fields.Select(fi => fi.Name).ToArray();

            return fieldNames;
        }

        public static double Average()
        {
            int count = 0;
            average = 0;

            foreach (int rating in Enum.GetValues(typeof(Student)))
            {
                count++;
                average += rating;
            }

            average /= count;
            return average;
        }
    }
}
