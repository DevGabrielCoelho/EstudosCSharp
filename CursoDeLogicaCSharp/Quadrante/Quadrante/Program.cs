using System;
using System.Globalization;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0) Console.WriteLine("primeiro");
                else if (x < 0 && y > 0) Console.WriteLine("segundo");
                else if (x < 0 && y < 0) Console.WriteLine("terceiro");
                else if (x > 0 && y < 0) Console.WriteLine("quarto");
                coordenadas = Console.ReadLine().Split(' ');
                x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
                y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);
            }
        }

    }
}