using System;
using System.Globalization;

namespace PositivosEMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4, valor5, valor6, media;
            int total;
            total = 0;
            media = 0.0;
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor1 > 0)
            {
                total += 1;
                media += (double) valor1;
            }
            if (valor2 > 0)
            {
                total += 1;
                media += (double) valor2;
            }
            if (valor3 > 0)
            {
                total += 1;
                media += (double) valor3;
            }
            if (valor4 > 0)
            {
                total += 1;
                media += (double) valor4;
            }
            if (valor5 > 0)
            {
                total += 1;
                media += (double) valor5;
            }
            if (valor6 > 0)
            {
                total += 1;
                media += (double) valor6;
            }
            media /= (double) total;
            Console.WriteLine(total + " valores positivos");
            Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));
        }
    }
}