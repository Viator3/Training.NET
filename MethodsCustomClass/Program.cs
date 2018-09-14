using System;

    //Make a mini-price model.
    //Enter a class with fields: name, price, availability.Fill an array with five objects.
    //Make a conclusion on the screen data on the conditions:
    //- availability in the warehouse;
    //- goods with a price below the entered price.

namespace MethodsCustomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices =
            {
                new Price("Samsung", 25.4m, 0),
                new Price("Aoc", 5.4m, 3),
                new Price("Philips", 12.8m, 0),
                new Price("Dell", 125.8m, 3),
                new Price("LG", 1.7m, 10)
            };

            Price.PriceStock(prices);

            Price.SearchByPrice(prices);

            Console.ReadKey();
        }
    }
}
