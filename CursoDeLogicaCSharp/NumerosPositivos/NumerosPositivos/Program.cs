using System;
using System.Globalization;

namespace NumerosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4, valor5, valor6;
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int total = 0;
            if (valor1 > 0)
            {
                total += 1;
            }
            if (valor2 > 0)
            {
                total += 1;
            }
            if (valor3 > 0)
            {
                total += 1;
            }
            if (valor4 > 0)
            {
                total += 1;
            }
            if (valor5 > 0)
            {
                total += 1;
            }
            if (valor6 > 0)
            {
                total += 1;
            }
            Console.WriteLine(total + " valores positivos");

        }
    }
}