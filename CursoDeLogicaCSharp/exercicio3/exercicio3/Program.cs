using System;
using System.Globalization;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, area, peri, diago;
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = x * y;
            peri = (y + x)*2;
            diago = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2));
            Console.WriteLine("AREA = " + area.ToString("f4", CultureInfo.InvariantCulture)); ;
            Console.WriteLine("PEÍMETRO = " + peri.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diago.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}