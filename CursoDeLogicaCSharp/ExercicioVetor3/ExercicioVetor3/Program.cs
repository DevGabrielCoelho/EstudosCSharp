using System;

namespace ExercicioVetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] entrada1 = Console.ReadLine().Split(' ');
            string[] entrada2 = Console.ReadLine().Split(' ');
            int[] numeros1 = new int[quantidade];
            int[] numeros2 = new int[quantidade];
            int[] soma = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                numeros1[i] = int.Parse(entrada1[i]);
                numeros2[i] = int.Parse(entrada2[i]);
                soma[i] = numeros1[i] + numeros2[i];
            }

            for (int i = 0; i < quantidade - 1; i++) Console.Write(soma[i] + " ");
            if (quantidade > 0) Console.WriteLine(soma[quantidade - 1]);
        }
    }
}