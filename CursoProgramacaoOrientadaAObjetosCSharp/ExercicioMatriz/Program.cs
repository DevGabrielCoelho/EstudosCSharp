using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDaMatriz = int.Parse(Console.ReadLine());
            int[,] matriz = new int[tamanhoDaMatriz, tamanhoDaMatriz];
            int contador = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(entrada[j]);
                    if (matriz[i, j] < 0) contador++;
                }
            }

            Console.WriteLine("Diagonal:");
            for (int i = 0; i < matriz.GetLength(0)-1; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }
            Console.WriteLine(matriz.GetLength(0)-1);

            Console.WriteLine($"Quantidade de numeros negativos: {contador}");
        }
    }
}