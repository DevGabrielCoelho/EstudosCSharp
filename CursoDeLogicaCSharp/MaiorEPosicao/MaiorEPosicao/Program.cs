using System;

namespace MaiorEPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 0;
            int maior = 0;
            for (int i = 1; i <= 6; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maior = numero;
                    posicao = i;
                }
                else if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}