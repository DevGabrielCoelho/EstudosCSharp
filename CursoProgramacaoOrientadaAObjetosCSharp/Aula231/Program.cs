using System;
using Aula231.Services;

namespace Aula231
{
    delegate void BinaryCalc(double x, double y);
    delegate void UnitaryCalc(double x);
    class Program
    {
        static void Main(string[] args)
        {
            BinaryCalc calc = CalcService.Max;
            calc += CalcService.Sum;
            UnitaryCalc calc1 = CalcService.Pow;
            calc1 += CalcService.Sqrt;

            calc(4, 16);
            calc1(4);
            calc1(16);
        }
    }
}