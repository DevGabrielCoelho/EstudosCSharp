using System;

namespace ExercicioMatriz5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tamanho = Console.ReadLine().Split(' ');

            int num1 = int.Parse(tamanho[0]);
            int num2 = int.Parse(tamanho[1]);

            int[,] matrix1 = new int[num1, num2];
            int[,] matrix2 = new int[num1, num2];
            int[,] matrix3 = new int[num1, num2];

            for (int i = 0; i < num1; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < num2; j++)
                {
                    matrix1[i, j] = int.Parse(entrada[j]);
                }

            }
            
            for (int i = 0; i < num1; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < num2; j++)
                {
                    matrix2[i, j] = int.Parse(entrada[j]);
                }
            }
            
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2-1; j++)
                {
                    Console.Write(matrix3[i, j] + " ");
                }
                Console.WriteLine(matrix3[i, num2-1]);
            }
        }
    }
}