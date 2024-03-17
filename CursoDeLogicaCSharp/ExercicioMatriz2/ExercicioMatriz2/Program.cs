using System;

namespace ExercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int[,] matrix = new int[quantidade, quantidade];
            int[] soma = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int o = 0; o < quantidade; o++)
                {
                    matrix[i, o] = int.Parse(entrada[o]);
                    soma[i] += matrix[i, o];
                }
            }

            foreach (int x in soma) Console.WriteLine(x);

        }
    }
}