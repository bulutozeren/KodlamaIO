using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName1 = "Elma";
            decimal price1 = 15;
            string description = "Amasya Elması";

            Product elma = new Product { Id = 1, Name = "Elma", Description = "Amasya elması", Price = 15 };
            Product karpuz = new Product { Id = 2, Name = "Karpuz", Description = "Diyarbakır karpuzu", Price = 10 };

            Product[] products = new Product[] { elma, karpuz };

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, {product.Description}, {product.Price}");
            }

            // instance - örnek
            CartManager cartManager = new CartManager();
            cartManager.Add(elma);
        }
    }
}
