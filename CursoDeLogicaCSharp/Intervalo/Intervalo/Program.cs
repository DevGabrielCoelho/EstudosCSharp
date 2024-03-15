using System;
using System.Globalization;

namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (X <= 25.00 && X >= 0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (X <= 50.00 && X >= 0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (X <= 75.00 && X >= 0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (X <= 100.00 && X >= 0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}