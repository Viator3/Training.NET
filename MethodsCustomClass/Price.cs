using System;

namespace MethodsCustomClass
{
    class Price
    {
        public string model;
        public decimal price;
        public int nal;

        public Price(string model, decimal price, int nal)
        {
            this.model = model;
            this.price = price;
            this.nal = nal;
        }

        public static void PriceStock(Price[] prices)
        {
            Console.WriteLine("In the warehouse at the moment we have:");

            foreach (Price stock in prices)
            {
                if (stock.nal > 0)
                {
                    Console.WriteLine("Model: {0}, price: {1}, nal: {2}", stock.model, stock.price, stock.nal);
                }
            }
        }

        public static void SearchByPrice(Price[] prices)
        {

            Console.Write("\nEnter the price below which the product will be searched: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Products with lower price {0}:", price);

            foreach (Price stock in prices)
            {
                if (stock.price < price)
                {
                    Console.WriteLine("Model: {0}, price: {1}, nal: {2}", stock.model, stock.price, stock.nal);
                }
            }
        }
    }
}
