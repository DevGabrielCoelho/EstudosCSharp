using System;
using System.Globalization;

namespace ExercicioMatriz6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = int.Parse(Console.ReadLine());
            double[,] matrix = new double[tamanho, tamanho];
            double somaposi = 0.0;

            for (int i = 0; i < tamanho; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < tamanho; j++)
                {
                    matrix[i, j] = double.Parse(entrada[j], CultureInfo.InvariantCulture);
                    if (matrix[i, j] > 0) somaposi += matrix[i, j];
                }
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA DOS POSITIVOS: " + somaposi.ToString("f1", CultureInfo.InvariantCulture));
          
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < tamanho-1; i++)
            {
                Console.Write(matrix[linha, i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine(matrix[linha, tamanho - 1].ToString("f1", CultureInfo.InvariantCulture));

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < tamanho-1; i++)
            {
                Console.Write(matrix[i, coluna].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine(matrix[tamanho - 1, coluna].ToString("f1", CultureInfo.InvariantCulture));

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(matrix[i, i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine(matrix[tamanho - 1, tamanho - 1].ToString("f1", CultureInfo.InvariantCulture));

            Console.WriteLine("MATRIZ ALTERNADA:");
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho-1; j++)
                {
                    if (matrix[i, j] < 0) matrix[i, j] = Math.Pow(matrix[i, j], 2);
                    Console.Write(matrix[i, j].ToString("f1", CultureInfo.InvariantCulture) + " ");
                }
                if (matrix[i, tamanho-1] < 0) matrix[i, tamanho-1] = Math.Pow(matrix[i, tamanho-1], 2);
                Console.WriteLine(matrix[i, tamanho-1].ToString("f1", CultureInfo.InvariantCulture));
            }

        }
    }
}