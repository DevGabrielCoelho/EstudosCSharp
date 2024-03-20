using System;
using System.Globalization;

namespace Exercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo(), y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (x.A + x.B + x.C) / 2,
                pY = (y.A + y.B + y.C) / 2,
                areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C)),
                areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

            char maior;

            if (areaX > areaY) maior = 'X';
            else maior = 'Y';

            Console.WriteLine($"Área de X = {areaX.ToString("f4", CultureInfo.InvariantCulture)}\n" +
                $"Área de Y = {areaY.ToString("f4", CultureInfo.InvariantCulture)}\n" +
                $"Maior área: {maior}");
        }
    }
}