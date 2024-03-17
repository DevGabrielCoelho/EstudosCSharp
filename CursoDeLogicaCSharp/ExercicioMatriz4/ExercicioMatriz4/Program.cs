using System;

namespace ExercicioMatriz4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int[,] matrix = new int[quantidade, quantidade];
            int soma = 0;

            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < quantidade; j++) matrix[i, j] = int.Parse(entrada[j]);
            }

            for (int i = 0; i < quantidade; i++) for (int j = 0; j < quantidade; j++) if (j >= i + 1) soma += matrix[i, j];

            Console.WriteLine(soma);

        }
    }
}