using System;
using System.Globalization;

namespace Aula69
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            double[] alturas = new double[quantidade];
            double media = 0.0;
            for (int i = 0; i < quantidade; i++)
            {
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media += alturas[i];
            }
            media/= (double)quantidade;
            Console.WriteLine($"Altura média: {media.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}