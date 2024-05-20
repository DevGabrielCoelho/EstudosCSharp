using Aula230.Services;
using System;

namespace Aula230
{
    delegate double BynaryCalc(double n1, double n2);
    delegate double UnaryCalc(double n1);
    class Program
    {
        static void Main(string[] args)
        {
            double x = 2.0;
            double y = 3.0;

            BynaryCalc sum = CalcService.Sum;
            BynaryCalc max = CalcService.Max;
            UnaryCalc square = CalcService.Square;

            Console.WriteLine($"{sum(x, y)}\n" +
                              $"{max(x,y)}\n" +
                              $"{square(x)}\n" +
                              $"{square(y)}");
        }
    }
}