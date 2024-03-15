using System;

namespace ExercicioVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];
            string[] entrada = Console.ReadLine().Split(' ');
            int par = 0;

            for (int i = 0; i < quantidade; i++)
            {
                numeros[i] = int.Parse(entrada[i]);
            }

            for (int i = 0; i < quantidade-1; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                    par++;
                }
            }
            if (numeros[quantidade-1] % 2 == 0)
            {
                Console.WriteLine(numeros[quantidade-1]);
                par++;
            }
            Console.WriteLine(par);
        }
    }
}