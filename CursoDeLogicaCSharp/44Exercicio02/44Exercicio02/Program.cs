using System;
using System.Globalization;

namespace E44xercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int idade = int.Parse(Console.ReadLine());
            int idade1 = 0;
            if (idade >= 0)
            {
                while (idade > 0)
                {
                    i += 1;
                    idade1 += idade;
                    idade = int.Parse(Console.ReadLine());
                }
                double media = (double) idade1 / i;
                Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
            }
            else Console.WriteLine("impossivel calcular");
        }
    }
}