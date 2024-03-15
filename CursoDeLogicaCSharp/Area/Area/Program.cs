using System;
using System.Globalization;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(' ');
            double a = double.Parse(x[0], CultureInfo.InvariantCulture);
            double b = double.Parse(x[1], CultureInfo.InvariantCulture);
            double c = double.Parse(x[2], CultureInfo.InvariantCulture);
            double cal = (double) (a * c) / 2;
            double cal2 = (double) 3.14159 * Math.Pow(c, 2.0);
            double cal3 = (double) ((a + b) * c) / 2;
            double cal4 = (double) Math.Pow(b, 2);
            double cal5 = (double) a * b;

            Console.WriteLine("TRIANGULO: " + cal.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + cal2.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + cal3.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + cal4.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + cal5.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}