using System;
using System.Globalization;

namespace ExercicioVetor8
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            double[] alturas = new double[quantidade];
            char[] sexo = new char[quantidade];
            double menoraltura = 0.0;
            double maioraltura = 0.0;
            double mediamulher = 0.0;
            int quantimedia = 0;
            int quantihomem = 0;

            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(entrada[1]);
            }

            for (int i = 0; i < quantidade; i++)
            {
                if (i == 0)
                {
                    menoraltura = alturas[i];
                    maioraltura = alturas[i];    
                }
                else
                {
                    if (alturas[i] > maioraltura) maioraltura = alturas[i];
                    if (alturas[i] < menoraltura) menoraltura = alturas[i];
                }

                if (sexo[i] == 'F')
                {
                    mediamulher += alturas[i];
                    quantimedia++;
                }
                else quantihomem++;
            }

            mediamulher = (double)mediamulher / quantimedia;

            Console.WriteLine("Menor altura = " + menoraltura.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maioraltura.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + mediamulher.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + quantihomem);

        }
    }
}