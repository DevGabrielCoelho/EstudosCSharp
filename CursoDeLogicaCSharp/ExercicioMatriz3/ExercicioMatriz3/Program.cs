using System;

namespace ExercicioMatriz3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int[,] matrix = new int[quantidade, quantidade];
            int[] maior = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int o = 0; o < quantidade; o++)
                {
                    matrix[i, o] = int.Parse(entrada[o]);
                }
            }

            for(int i = 0; i < quantidade; i++)
            {
                for (int j = 0; j < quantidade; j++)
                {
                    if (!(maior[i] < 0 && maior[i] > 0 && maior[i] == 0)) maior[i] = matrix[i, j];
                    else if (matrix[i, j] < maior[i]) maior[i] = matrix[i, j];
                }
            }
            foreach (int numeros in maior) Console.WriteLine(numeros);

        }
    }
}