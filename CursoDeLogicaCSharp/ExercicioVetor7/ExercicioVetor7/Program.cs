using System;
using System.Globalization;

namespace ExercicioVetor7
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] nomes = new string[quantidade];
            double[] notas1 = new double[quantidade]; 
            double[] notas2 = new double[quantidade]; 

            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                nomes[i] = entrada[0];
                notas1[i] = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                notas2[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < quantidade; i++) if ((double)(notas1[i] + notas2[i])/2.0 >= 6.0) Console.WriteLine(nomes[i]);
        }
    }
}