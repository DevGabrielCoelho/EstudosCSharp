using System;
using System.Globalization;

namespace Aula54
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double[] v = new double[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                v[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}