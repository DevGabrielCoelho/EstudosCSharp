using System;
using System.Globalization;

namespace VariasNotasComValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int repete = 1;
            while (repete == 1)
            {
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                double media = (nota1 + nota2) / 2;
                Console.WriteLine("media = " + media.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                repete = int.Parse(Console.ReadLine());
                while (repete < 1 || repete > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    repete = int.Parse(Console.ReadLine());
                }
            }
            
        }
    }
}