using System;

namespace SomaDeImparesConsecutivosII
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int numero1, numero2, soma, min, max;
            for (int i = 0; i < quantidade; i++)
            {
                soma = 0;
                string[] numeros = Console.ReadLine().Split(' ');
                numero1 = int.Parse(numeros[0]);
                numero2 = int.Parse(numeros[1]);
                min = numero1;
                max = numero2;
                if (numero1 > numero2)
                {
                    min = numero2;
                    max = numero1;
                }
                for (min++; min < max; min++)
                {
                    if (min % 2 != 0)
                    {
                        soma += min;
                    }
                }
                Console.WriteLine(soma);
            }

        }
    }
}