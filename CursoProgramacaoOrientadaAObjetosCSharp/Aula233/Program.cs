using Aula233.Entities;
using System;

namespace Aula233
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV1", 2000));
            products.Add(new Product("TV2", 2000));
            products.Add(new Product("TV3", 2000));
            products.Add(new Product("TV4", 2000));

            Action<Product> action = products => { products.Price += products.Price * 0.1; };

            Action<Product> action2 = PriceUpdate;

            products.ForEach(action);

            products.ForEach(action2);

            products.ForEach(products => { products.Price += products.Price * 0.1; });
        }

        static void PriceUpdate(Product product)
        {
            product.Price += product.Price * 0.1;
        }

    }
}