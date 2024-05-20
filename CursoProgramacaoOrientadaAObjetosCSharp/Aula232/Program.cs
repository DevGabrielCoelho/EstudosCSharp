using Aula232.Entities;
using System;

namespace Aula232
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV1", 2000.00));
            products.Add(new Product("TV2", 3000.00));
            products.Add(new Product("TV3", 4000.00));
            products.Add(new Product("TV4", 5000.00));

            products.RemoveAll(products => products.Price >= 4000);
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            products.Add(new Product("TV3", 4000.00));
            products.Add(new Product("TV4", 5000.00));
        
            products.RemoveAll(ProductTest);
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        static bool ProductTest(Product product)
        {
            return product.Price >= 4000;
        }
    }
}