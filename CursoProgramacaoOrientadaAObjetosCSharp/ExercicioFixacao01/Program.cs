using ExercicioFixacao01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int productQuantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < productQuantity; i++)
            {
                Console.Write($"\nProduct #{i + 1} data:\nCommon, used or imported (c/u/i)? ");
                char cuiQuestion = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (cuiQuestion == 'u' || cuiQuestion == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    products.Add(new UsedProduct(productName, productPrice, manufactureDate));
                }
                else if (cuiQuestion == 'i' || cuiQuestion == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(productName, productPrice, customsFee));
                }
                else
                {
                    products.Add(new Product(productName, productPrice));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}