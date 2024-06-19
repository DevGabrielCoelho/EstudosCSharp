using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[12, 12];
            int line = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] =  double.Parse(Console.ReadLine());
                }
            }
            double sum = 0;
            for (int i = 0;i < matriz.GetLength(0); i++)
            {
                sum += matriz[i, line];
            }
            if (op == 'M') sum /= 12;
            Console.WriteLine(sum.ToString("f1"));
        }
    }
}