using System;

namespace MultiplosDe13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int min = numero1;
            int max = numero2;
            int soma = 0;
            if (numero1 > numero2)
            {
                max = numero1;
                min = numero2;
            }
            for (int i = 0; i <= (max - min); i++)
            {
                if ((min + i) % 13 != 0) soma += min + i;
            }
            Console.WriteLine(soma);
        }
    }
}