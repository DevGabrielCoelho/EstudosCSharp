using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] numeros = Console.ReadLine().Split(' ');
            int[] vetor = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                vetor[i] = int.Parse(numeros[i]);
            }
            for (int i = 0; i < quantidade; i++)
            {
                if (vetor[i] < 0) Console.WriteLine(vetor[i]);
            }
        }
    }
}