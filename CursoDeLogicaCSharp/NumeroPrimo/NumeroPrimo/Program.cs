using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                int dividido = 0;
                int numero = int.Parse(Console.ReadLine());
                for (int o = 1; o <= numero; o++)
                {
                    if (numero % o == 0) dividido++;
                }
                if (dividido == 2) Console.WriteLine(numero + " eh primo");
                else Console.WriteLine(numero + " nao eh primo");
            }
        }
    }
}