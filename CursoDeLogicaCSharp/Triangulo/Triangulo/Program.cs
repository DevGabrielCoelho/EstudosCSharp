using System;
using System.Globalization;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] agrs)
        {
            double a, b, c, perimetro, area;
            string[] tamanhos = Console.ReadLine().Split(' ');
            a = double.Parse(tamanhos[0], CultureInfo.InvariantCulture);
            b = double.Parse(tamanhos[1], CultureInfo.InvariantCulture);
            c = double.Parse(tamanhos[2], CultureInfo.InvariantCulture);
            if ((a < (b + c)) && (b < (a + c)) && (c < (a + b)))
            {
                perimetro = (double) a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("f1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = (double) ((a + b) * c) / 2.0;
                Console.WriteLine("Area = " + area.ToString("f1", CultureInfo.InvariantCulture));
            }
        }
    }
}