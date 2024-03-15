using System;
using System.Globalization;

namespace FormulaDeBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, calc1, calc2;
            string[] X = Console.ReadLine().Split(' ');
            A = double.Parse(X[0], CultureInfo.InvariantCulture);
            B = double.Parse(X[1], CultureInfo.InvariantCulture);
            C = double.Parse(X[2], CultureInfo.InvariantCulture);
            calc1 = (-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);
            calc2 = (-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);
            if (((Math.Pow(B, 2) - 4 * A * C) <= 0) || ((2 * A) == 0))
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + calc1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + calc2.ToString("f5", CultureInfo.InvariantCulture));
            }
        }
    }
}