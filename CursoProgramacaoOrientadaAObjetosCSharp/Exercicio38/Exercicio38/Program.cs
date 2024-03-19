using System;
using System.Globalization;

namespace Exercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), 
                bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), 
                cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            double aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), 
                bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), 
                cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (aX + bX + cX) / 2,
                pY = (aY + bY + cY) / 2,
                areaX = Math.Sqrt(pX * (pX - aX) * (pX - bX) * (pX - cX)),
                areaY = Math.Sqrt(pY * (pY - aY) * (pY - bY) * (pY - cY));

            char maior;

            if (areaX > areaY) maior = 'X';
            else maior = 'Y';

            Console.WriteLine($"Área de X = {areaX.ToString("f4", CultureInfo.InvariantCulture)}\n" +
                $"Área de Y = {areaY.ToString("f4", CultureInfo.InvariantCulture)}\n" +
                $"Maior área: {maior}");
        }
    }
}