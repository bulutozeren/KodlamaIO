using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        // naming convertion
        public void Add(Product product)
        {
            //Console.WriteLine("Sepete eklendi.");
            Console.WriteLine($"{product.Name} sepete başarıyla eklendi.");
        }
    }
}
