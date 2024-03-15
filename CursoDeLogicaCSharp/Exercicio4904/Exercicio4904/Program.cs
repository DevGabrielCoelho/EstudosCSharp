using System;

namespace Exercicio4904
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int soma = 0;
            int min, max;
            if (numero1 > numero2)
            {
                max = numero1;
                min = numero2;
            }
            else
            {
                max = numero2;
                min = numero1;
            }
            for (int i = max-1; i >= min; i--)
            {
                if (i % 2 != 0) soma += i;
            }
                Console.WriteLine(soma);
            
        }
    }
}