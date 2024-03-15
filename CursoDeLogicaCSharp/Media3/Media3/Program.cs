using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Media3
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;
            string[] x = Console.ReadLine().Split(' ');
            nota1 = float.Parse(x[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(x[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(x[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(x[3], CultureInfo.InvariantCulture);
            media = (float) ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / (2 + 3 + 4 + 1);
            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                float notaexame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaexame.ToString("f1", CultureInfo.InvariantCulture));
                float mediafinal = (float)(notaexame + media) / 2;
                if (mediafinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediafinal.ToString("f1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media: " + string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:#.#}", media));
                }
            }
            else
            {
                Console.WriteLine("Media: " + string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:#.#}", media));
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}