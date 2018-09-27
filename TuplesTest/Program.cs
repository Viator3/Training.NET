using System;

//There are two tables with several fields, the types of fields in the tables are different from each other, but comparable.
//Use the tuple to rewrite the data from one table to another.

namespace TuplesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = {
                new Table { table = (0, "a", 0.1) },
                new Table { table = (1, "b", 1.1) },
                new Table { table = (2, "c", 2.2) },
                new Table { table = (3, "d", 3.3) },
                new Table { table = (4, "e", 4.4) }
            };
            
            TableLong[] tablesLong = {
                new TableLong { tableLong = (300000000, "a1", 10.1) },
                new TableLong { tableLong =(300000001, "b2", 21.1) },
                new TableLong { tableLong =(300000002, "c3", 32.2) },
                new TableLong { tableLong =(300000003, "d4", 43.3) },
                new TableLong { tableLong =(300000004, "e5", 54.4) }
            };

            for (int index = 0; index < tablesLong.Length; index++)
            {
                tablesLong[index].tableLong = tables[index].table;
            }

            foreach (TableLong line in tablesLong)
            {
                Console.WriteLine("id = {0}, name = {1}, price = {2}", line.tableLong.id, line.tableLong.name, line.tableLong.price);
            }

            Console.ReadKey();
        }
    }
}
