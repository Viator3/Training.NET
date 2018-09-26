using System;

//There are two tables with several fields, the types of fields in the tables are different from each other, but comparable.
//Use the tuple to rewrite the data from one table to another.

namespace TuplesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name, double price)[] tables = {
                (0, "a", 0.1),
                (1, "b", 1.1),
                (2, "c", 2.2),
                (3, "d", 3.3),
                (4, "e", 4.4)
            };

            (long id, string name, double price)[] tablesLong = {
                (300000000, "a1", 10.1),
                (300000001, "b2", 21.1),
                (300000002, "c3", 32.2),
                (300000003, "d4", 43.3),
                (300000004, "e5", 54.4)
            };

            for (int index = 0; index < tablesLong.Length; index++)
            {
                tablesLong[index] = tables[index];
            }

            foreach ((long id, string name, double price) tableLong in tablesLong)
            {
                Console.WriteLine("id = {0}, name = {1}, price = {2}", tableLong.id, tableLong.name, tableLong.price);
            }

            Console.ReadKey();
        }
    }
}
