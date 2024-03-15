using System;

namespace SomaDeImparesConsecutivosIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int numero1, numero2, soma;
            for (int i = 1; i <= quantidade; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                numero1 = int.Parse(numeros[0]);
                numero2 = int.Parse(numeros[1]);
                if (numero1 % 2 == 0) numero1++;
                soma = numero1;
                for (int o = 1; o < numero2; o++)
                {
                    soma += numero1 + 2;
                    numero1 += 2;
                }
                Console.WriteLine(soma);
            }
        }
    }
}