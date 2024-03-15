using System;
using System.Globalization;

namespace ExercicioVetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] entrada = Console.ReadLine().Split(' ');
            int[] numeros = new int[quantidade];
            double media = 0.0;
            int quantidadepar = 0;

            for (int i = 0; i < quantidade; i++)
            {
                numeros[i] = int.Parse(entrada[i]);
                if (numeros[i] % 2 == 0)
                {
                    media += numeros[i];
                    quantidadepar++;
                }
            }

            media = (double)media / quantidadepar;

            Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));
        }
    }
}