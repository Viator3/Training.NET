using System;

//Lifting capacity of the lift is 460 kg.
//The schoolboy weighs 30 kg, the student - 50 kg.
//Learn the number of students and students in the elevator and the remaining space.

namespace LiftingCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
            int weightSchoolboy = 30;
            int weightStudent = 50;

            int[] schoolboy = Capacity(weightSchoolboy);
            int[] student = Capacity(weightStudent);

            Console.WriteLine($"The number of schoolboys who climbed the elevator: {schoolboy[0]}, and the remaining seat: {schoolboy[1]} kg.");
            Console.WriteLine($"The number of students who climbed the elevator: {student[0]}, and the remaining seat: {student[1]} kg.");
            Console.ReadKey();

            int[] Capacity(int weighPerson)
            {
                int liftingCapacity = 460;
                int numberSeats = liftingCapacity / weighPerson;
                int remainingPlace = liftingCapacity % weighPerson;
                int[] result = { numberSeats, remainingPlace };
                return result;
            }

        }
    }
}
