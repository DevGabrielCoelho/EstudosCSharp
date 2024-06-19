using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[3,3];
            char op = char.Parse(Console.ReadLine());
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double sum = 0.0;
            int count = 0;
            int x = matriz.GetLength(0)-1;
            /* i = 1
             * j = 0
             1 2 3
             4 5 6
             7 8 9
             */
            for (int i = 0;i < matriz.GetLength(0)-1; i++)
            {
                for(int j = 0;j < x; j++)
                {
                    sum += matriz[i, j];
                    count++;
                }
                x--;
            }
            if (op == 'M') sum /= count;
            Console.WriteLine(sum.ToString("f1"));
        }
    }
}