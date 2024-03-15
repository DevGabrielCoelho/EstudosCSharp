using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args) 
        {
            int quantidade = int.Parse(Console.ReadLine());
            double[] vetor = new double[quantidade];
            string[] numeros = Console.ReadLine().Split(' ');
            double soma = 0.0;
            double media = 0.0;

            for (int i = 0; i < quantidade; i++)
            {
                vetor[i] = double.Parse(numeros[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < quantidade - 1; i++)
            {
                Console.Write(vetor[i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            if (quantidade > 0) Console.WriteLine(vetor[quantidade - 1].ToString("f1", CultureInfo.InvariantCulture));

            for (int i = 0; i < quantidade; i++)
            {
                soma += vetor[i];
            }
            Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));

            media = (double)soma / quantidade;
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}