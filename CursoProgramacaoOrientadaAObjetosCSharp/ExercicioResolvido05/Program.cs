using Entities;
using System;
using System.Globalization;

namespace ExercicioResolvido05
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new FileInfo(Console.ReadLine()).OpenRead();
                streamReader = new StreamReader(fileStream);

                List<Product> products = new List<Product>();
                while (streamReader.EndOfStream)
                {
                    string[] strings = streamReader.ReadLine().Split(',');
                    products.Add(new Product(strings[0], double.Parse(strings[1], CultureInfo.InvariantCulture)));
                }

                double average = products.DefaultIfEmpty().Average(x => x.Price);
                Console.WriteLine($"Average: ${average.ToString("f2", CultureInfo.InvariantCulture)}");

                IOrderedEnumerable<Product> p = products.Where(x => x.Price < average).OrderByDescending(x => x.Name);
                foreach (Product x in p)
                {
                    Console.WriteLine(x.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex + "!");
                Console.ReadLine();
            }
            finally
            {
                if (fileStream != null) fileStream.Close();
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}