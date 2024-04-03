using System;

namespace ExercicioFixacaoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tamanhoMatriz = Console.ReadLine().Split(' ');
            int[,] matriz = new int[int.Parse(tamanhoMatriz[0]), int.Parse(tamanhoMatriz[1])];
            List<int[]> posicoes = new List<int[]>();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(entrada[j]);
                }
            }

            int find = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == find)
                    {
                        posicoes.Add([i, j]);
                    }
                }
            }
            for (int i = 0; i < posicoes.Count; i++)
            {
                Console.WriteLine($"\nPosição: {posicoes[i][0]},{posicoes[i][1]}");
                if ((posicoes[i][0] - 1) >= 0)
                {
                    Console.WriteLine($"Cima: {matriz[posicoes[i][0] - 1, posicoes[i][1]]}");
                }
                if ((posicoes[i][0] + 1) <= int.Parse(tamanhoMatriz[0]) - 1)
                {
                    Console.WriteLine($"Baixo: {matriz[posicoes[i][0] + 1, posicoes[i][1]]}");
                }
                if ((posicoes[i][1] - 1) >= 0)
                {
                    Console.WriteLine($"Esquerda: {matriz[posicoes[i][0], posicoes[i][1] - 1]}");
                }
                if (posicoes[i][1] + 1 <= int.Parse(tamanhoMatriz[1]) - 1)
                {
                    Console.WriteLine($"Direita: {matriz[posicoes[i][0], posicoes[i][1] + 1]}");
                }
            }
        }
    }
}