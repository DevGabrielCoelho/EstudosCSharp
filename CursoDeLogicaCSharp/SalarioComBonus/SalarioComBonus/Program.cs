using System;
using System.Globalization;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ven = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double com = (double) ((ven / 100.0) * 15.0) + sal;
            Console.WriteLine("TOTAL = R$ " + com.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}