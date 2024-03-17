using System;
using System.Numerics;

namespace ExercicioMatriz7
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = int.Parse(Console.ReadLine());
            int soldados = int.Parse(Console.ReadLine());
            int[,] pelotao = new int[soldados, filas];
            int[] backup = new int[soldados];

            for (int i = 0; i < filas; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < soldados; j++)
                {
                    pelotao[j, i] = int.Parse(entrada[j]);
                }
            }

            int girar = int.Parse(Console.ReadLine()) - 1;
            for (int i = 0; i < soldados; i++)
            {
                backup[i] = pelotao[i, girar];
            }

            for (int i = 0; i < soldados; i++)
            {
                if (i == 0) pelotao[i, girar] = backup[soldados-1];
                else pelotao[i, girar] = backup[i - 1];
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < soldados-1; j++)
                {
                    Console.Write(pelotao[j, i] + " ");
                }
                Console.WriteLine(pelotao[soldados - 1, i]);
            }

        }
    }
}