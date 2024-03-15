using System;

namespace Exercicio66
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int[,] matrix = new int[quantidade, quantidade];
            int negativo = 0;

            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < quantidade; j++)
                {
                    matrix[i, j] = int.Parse(entrada[j]);
                    if (matrix[i, j] < 0) negativo++;
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");

            for (int i = 0; i < quantidade-1; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine(matrix[quantidade-1, quantidade-1]);

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativo);
        }
    }
}