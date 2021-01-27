using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product masa = new Product
            {
                Id = 1,
                CategoryId = 2,
                Name = "Masa",
                UnitPrice = 500,
                UnitsInStock = 3
            };

            Product product = new Product
            {
                Id = 2,
                CategoryId = 5,
                Name = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 5
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
        }
    }
}
