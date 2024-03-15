using System;
using System.Globalization;

namespace ExercicioVetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] entrada = Console.ReadLine().Split(' ');
            double[] numeros = new double[quantidade];
            double media = 0.0;

            for (int i = 0; i < quantidade; i++) 
            {    
                numeros[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
                media += numeros[i];
            }
            media /= quantidade;
            Console.WriteLine(media.ToString("f3", CultureInfo.InvariantCulture));
            foreach (double x in numeros) if (x < media) Console.WriteLine(x.ToString("f1", CultureInfo.InvariantCulture));
        }
    }
}