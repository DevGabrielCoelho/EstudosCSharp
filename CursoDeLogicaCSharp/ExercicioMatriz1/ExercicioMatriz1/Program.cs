using System;

namespace ExercicioMatriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] quantidade = Console.ReadLine().Split(' ');
            int num1 = int.Parse(quantidade[0]);
            int num2 = int.Parse(quantidade[1]);
            int[,] matrix = new int[num1, num2];

            for (int i = 0; i < num1; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int o = 0; o < num2; o++)
                {
                    matrix[i, o] = int.Parse(entrada[o]);
                }
            }

            Console.WriteLine("NUMEROS NEGATIVOS:");
            foreach (int negativos in matrix) if (negativos < 0) Console.WriteLine(negativos);

        }
    }
}