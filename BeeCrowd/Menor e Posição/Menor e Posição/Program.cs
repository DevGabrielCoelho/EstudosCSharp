using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] vetor = new int[length];
            string[] numbers = Console.ReadLine().Split(' ');
            int menor = int.Parse(numbers[0]);
            int poss = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(numbers[i]);
                if (menor > vetor[i])
                {
                    menor = vetor[i];
                    poss = i;
                }
            }
            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Posicao: {poss}");
        }
    }
}