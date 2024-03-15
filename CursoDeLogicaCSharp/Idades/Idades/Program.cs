using System;
using System.Globalization;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, soma;
            idade = int.Parse(Console.ReadLine());
            soma = 0;
            double i = 0.0;
            while(idade >= 0)
            {
                soma += idade;
                i += 1.0;
                idade = int.Parse(Console.ReadLine());
            }
            double media = (double) (soma / i);
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}