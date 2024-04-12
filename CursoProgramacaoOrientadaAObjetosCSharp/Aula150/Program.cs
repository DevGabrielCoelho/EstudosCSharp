using System;
using System.Globalization;
using System.Xml.Serialization;

namespace Aula150
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<double> doubles = new List<double>();
                Console.WriteLine("Dividing numbers");
                Console.Write("Enter the dividend: ");
                doubles.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.Write("Enter the divider: ");
                doubles.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                double quotient = doubles[0] / doubles[1];
                Console.WriteLine($"Result: {quotient.ToString(CultureInfo.InvariantCulture)}");
            }
            catch (FormatException a)
            {
                Console.WriteLine($"Error! {a.Message}");
                Main(args);
            }

        }
    }
}