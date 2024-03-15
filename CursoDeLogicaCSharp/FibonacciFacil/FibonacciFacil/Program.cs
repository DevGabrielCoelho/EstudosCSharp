using System;
using System.Runtime.Serialization;

namespace FibonacciFacil
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int soma = 0;
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                if (i == 1 && quantidade != i) Console.Write(x + " ");
                else if (i == 1 && quantidade == i) Console.WriteLine(x);
                else if (i == 2 && quantidade != i) Console.Write(y + " ");
                else if (i == 2 && quantidade == i) Console.WriteLine(y);
                else if (i >= 3 && i != quantidade) Console.Write(soma + " ");
                else if (i >= 3 && i == quantidade) Console.WriteLine(soma);
                if (i >= 2)
                {
                    soma = x + y;
                    x = y;
                    y = soma;
                }
            }
        }
    }
}