using System;

namespace Exercicio67
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int num1 = int.Parse(entrada[0]);
            int num2 = int.Parse(entrada[1]);
            int[,] matrix = new int[num1, num2];
            int[] soma = new int[num1];

            for (int i = 0; i < num1; i++)
            {
                string[] entrada2 = Console.ReadLine().Split(' ');
                for (int o = 0; o < num2; o++)
                {
                    matrix[i, o] = int.Parse(entrada2[o]);
                    soma[i] += matrix[i, o];
                }
            }

            for (int i = 0; i < num1; i++)
            {
                Console.WriteLine(soma[i]);
            }

        }
    }
}