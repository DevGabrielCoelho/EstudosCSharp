using System;
using System.Globalization;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());

            string[] nomes = new string[quantidade];
            int[] idades = new int[quantidade];
            double[] alturas = new double[quantidade];
            double mediaaltura = 0.0;
            double menores = 0;

            for (int i = 0; i < quantidade; i++)
            {
                string[] pessoa = Console.ReadLine().Split(' ');

                nomes[i] = pessoa[0];
                idades[i] = int.Parse(pessoa[1]);
                alturas[i] = double.Parse(pessoa[2], CultureInfo.InvariantCulture);

                mediaaltura += alturas[i];
                if (idades[i] < 16) menores++;
            }

            mediaaltura = (double)(mediaaltura /quantidade);
            menores = (double)((menores * 100) / quantidade);

            Console.WriteLine("Altura Média: " + mediaaltura.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: " + menores.ToString("f1", CultureInfo.InvariantCulture) + "%");
        }
    }
}