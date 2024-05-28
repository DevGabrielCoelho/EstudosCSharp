using Entities;
using System;
using System.Globalization;

namespace ExercicioResolvido05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();

                Console.Write("Enter full file path: ");
                using (StreamReader streamReader = File.OpenText(Console.ReadLine()))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] strings = streamReader.ReadLine().Split(',');
                        products.Add(new Product(strings[0], double.Parse(strings[1], CultureInfo.InvariantCulture)));
                    }
                }

                double average = products.Average(x => x.Price);
                Console.WriteLine($"Average: ${average.ToString("f2", CultureInfo.InvariantCulture)}");

                IEnumerable<string> averageProducts = products.
                    Where(product => product.Price < average).
                    OrderByDescending(product => product.Name).
                    Select(product => product.Name);
                foreach (string name in averageProducts) Console.WriteLine(name);
            }

            catch (Exception ex) { Console.WriteLine("Error! " + ex.Message + "!"); }
        }
    }
}