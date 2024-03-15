using System;
using System.Globalization;

namespace DistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            string[] v1 = Console.ReadLine().Split(' ');
            string[] v2 = Console.ReadLine().Split(' ');
            x1 = double.Parse(v1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(v1[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(v2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(v2[1], CultureInfo.InvariantCulture);
            double calc = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2));
            Console.WriteLine(calc.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}