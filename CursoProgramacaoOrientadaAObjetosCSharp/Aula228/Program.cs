using Aula228.Entities;
using System;

namespace Aula228
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 2000.00));
            products.Add(new Product("CELL", 3000.00));
            products.Add(new Product("PC", 4000.00));

            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}