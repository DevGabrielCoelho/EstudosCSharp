using System;

namespace Aula46
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade, numero, soma;
            quantidade = int.Parse(Console.ReadLine());
            numero = 0;
            soma = 0;
            for (int i = 1; i <= quantidade; i++)
            {
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            }
            Console.WriteLine(soma);
            Console.WriteLine();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("O valor de i é: " + i);
            }
            Console.WriteLine();

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("O valor de i é: " + i);
            }

            int x = 4;
            int y = x + 2;
            for (int i = 0; i < x; i++)
            {
                Console.Write(x + " " + y);
                y += i;
            }
        }
    }
}