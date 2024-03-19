using System;
using System.Globalization;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto = Console.ReadLine();
            int quantidadeQuartos = int.Parse(Console.ReadLine());
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] entrada = Console.ReadLine().Split(' ');
            string sobreNome = entrada[0];
            int idade = int.Parse(entrada[1]);
            float altura = float.Parse(entrada[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nomeCompleto}\n" +
                $"{quantidadeQuartos}\n" +
                $"{preco.ToString("f2", CultureInfo.InvariantCulture)}\n" +
                $"{sobreNome}\n" +
                $"{idade}\n" +
                $"{altura.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}