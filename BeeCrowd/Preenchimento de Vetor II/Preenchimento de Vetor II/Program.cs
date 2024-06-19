using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[1000];
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (count == input) count = 0;
                vetor[i] = count;
                count++;
            }
            for (int i = 0;i < vetor.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {vetor[i]}");
            }
        }
    }
}