using System;

//Create a class in which to restart the operators: "+", "==", "! =", For arrays of the form int[] Arr = new int[5];
//"+" - array elements are indexed sequentially;
//"==" - true if array elements are identical;
//"! =" - true, if there is a difference, although b is in one element.

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            OverLoad arr1 = new OverLoad();
            OverLoad arr2 = new OverLoad();
            OverLoad arr3 = new OverLoad();

            arr1.Arr = new int[] { 0, 2, 5, 15, 3 };
            arr2.Arr = new int[] { 0, 2, 5, 15, 3 };

            arr3 = arr1 + arr2;

            Console.WriteLine(arr1 == arr2);

            Console.WriteLine(arr1 != arr2);

            foreach (int number in arr3.Arr)
            {
                Console.Write("{0} ", number);
            }

            Console.ReadKey();
        }
    }
}
