using System;
using System.Globalization;

namespace MediasPonderadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                string[] notas = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                double nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                double nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
                double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / (2 + 3 + 5);
                Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));
            }
        }
    }
}