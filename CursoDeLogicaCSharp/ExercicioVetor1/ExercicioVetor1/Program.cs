using System;
using System.Diagnostics;
using System.Globalization;

namespace ExercicioVetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] entrada = Console.ReadLine().Split(' ');
            double[] numeros = new double[quantidade];
            int posicao = 0;
            double maior = 0.0;
            for (int i = 0; i < quantidade; i++)
            {
                numeros[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < quantidade; i++)
            {
                if (i == 0)
                {
                    posicao = i;
                    maior = numeros[i];
                }
                else
                {
                    if (numeros[i] > maior)
                    {
                        posicao = i;
                        maior = numeros[i];
                    }
                }
            }
            Console.WriteLine(maior.ToString("f1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}