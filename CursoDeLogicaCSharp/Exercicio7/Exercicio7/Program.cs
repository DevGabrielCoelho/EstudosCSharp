using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            if (A > 100) 
            {
                int B = A - 100;
                double calc = (double) (B * 2.00) + 50.00;
                Console.WriteLine("Valor a pagar: R$ " + calc.ToString("f2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Valor a pagar: R$ 50.00");
            }
        }
    }
}