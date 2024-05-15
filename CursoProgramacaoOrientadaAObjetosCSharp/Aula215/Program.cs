using System;
using Entities;
using Services;

namespace Aula215
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 2000.00));
            products.Add(new Product("PC", 3000.00));
            products.Add(new Product("CELL", 4000.00));
            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(products);
            Console.WriteLine(max);
        }
    }
}