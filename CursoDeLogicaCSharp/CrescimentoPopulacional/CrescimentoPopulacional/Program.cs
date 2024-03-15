using System;
using System.Globalization;

namespace CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            for (int o = 1; o <= quantidade; o++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int população1 = int.Parse(numeros[0]);
                int população2 = int.Parse(numeros[1]);
                double crescimento1 = double.Parse(numeros[2], CultureInfo.InvariantCulture);
                double crescimento2 = double.Parse(numeros[3], CultureInfo.InvariantCulture);
                int anos = 0;

                crescimento1 /= 100;
                crescimento2 /= 100;

                while (população1 <= população2 && anos <= 100)
                {
                    população1 += (int)(população1 * crescimento1);
                    população2 += (int)(população2 * crescimento2);
                    anos++;
                }

                if (anos > 100)
                    Console.WriteLine("Mais de 1 seculo.");
                else
                    Console.WriteLine(anos + " anos.");
            }
        }
    }
}
