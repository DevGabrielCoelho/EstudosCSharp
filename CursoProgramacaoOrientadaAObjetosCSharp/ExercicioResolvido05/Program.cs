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
                using (StreamReader streamReader = File.OpenText(@"C:\Estudos\CursoProgramacaoOrientadaAObjetosCSharp\ExercicioResolvido05\in.txt"))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] strings = streamReader.ReadLine().Split(',');
                        products.Add(new Product(strings[0], double.Parse(strings[1], CultureInfo.InvariantCulture)));
                    }
                }

                double average = products.Average(x => x.Price);
                Console.WriteLine($"Average: ${average.ToString("f2", CultureInfo.InvariantCulture)}");

                IOrderedEnumerable<Product> p = products.Where(x => x.Price < average).OrderByDescending(x => x.Name);
                foreach (Product x in p)
                {
                    Console.WriteLine(x.Name);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message + "!");
                Console.ReadLine();
            }
        }
    }
}