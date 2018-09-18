using System;

//Create several inherited classes from one parent.
//Create a virtual method in the parent class, override the same method in the child classes.

namespace VirtualTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Human student = new Student();
            Human teacher = new Teacher();
            
            human.Payment();           
            student.Payment();            
            teacher.Payment();

            Console.ReadKey();
        }
    }
}
