using System;

namespace Aula63
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhacoluna = Console.ReadLine().Split(' ');
            int linha = int.Parse(linhacoluna[0]);
            int coluna = int.Parse(linhacoluna[1]);
            int[,] numeros = new int[linha, coluna];
            
            Console.WriteLine();

            for (int i = 0; i < linha; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                for (int o = 0; o < coluna; o++)
                {
                    numeros[i, o] = int.Parse(entrada[o]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < linha; i++)
            {
                for (int o = 0; o < coluna - 1; o++)
                {
                    Console.Write(numeros[i, o] + " ");
                }
                Console.WriteLine(numeros[i, coluna - 1]);
            }

            Console.WriteLine();

            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

        }
    }
}