using Aula234.Entities;
using System;

namespace Aula234
{
    
    class Program
    {
        static string NameUper(Product product)
        {
            return product.Name.ToUpper();
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Tv", 2000.00));
            products.Add(new Product("Tv1", 3000.00));
            products.Add(new Product("Tv2", 4000.00));
            products.Add(new Product("Tv3", 5000.00));

            Func<Product, string> func = NameUper;
            Func<Product, string> func1 = product => product.Name.ToUpper();

            List<string> result = products.Select(func).ToList();
            List<string> result1 = products.Select(func1).ToList();
            List<string> result2 = products.Select(products => products.Name.ToUpper()).ToList();

            foreach (string product in result) 
            {
                Console.WriteLine(product);
            }
        }
    }
}