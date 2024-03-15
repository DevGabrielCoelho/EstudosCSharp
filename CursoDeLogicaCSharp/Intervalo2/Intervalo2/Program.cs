using System;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fora = 0;
            int dentro = 0;
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                int numeros = int.Parse(Console.ReadLine());
                if (numeros < 10 || numeros > 20) fora += 1;
                else if (numeros >= 10 && numeros <= 20) dentro += 1;
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}