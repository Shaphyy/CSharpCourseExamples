using System;

namespace OOP1
{
    public class ProductService
    {
        public void Add(Product product)
        {
           Console.WriteLine(product.ProductName + " eklendi"); 
        }
    }
}