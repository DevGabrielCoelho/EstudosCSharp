using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] x = Console.ReadLine().Split(' ');
            A = int.Parse(x[0]);
            B = int.Parse(x[1]);
            C = int.Parse(x[2]);

            if (A < B && A < C)
            {
                Console.WriteLine("MENOR = " + A);
            }
            else
            {
                if (B < A && B < C)
                {
                    Console.WriteLine("MENOR = " + B);
                }
                else
                {
                    Console.WriteLine("MENOR = " + C);
                }
            }
        }
    }
}