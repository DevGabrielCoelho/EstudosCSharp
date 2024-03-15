using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] agrs)
        {
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (renda <= 3000.00)
            {
                renda -= 2000;
                renda = (renda / 100.00) * 8.00;
                Console.WriteLine("R$ " + renda.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (renda <= 4500.00)
            {
                renda -= 2000;
                renda = (((renda - 1000)/100) * 18) + (((renda - (renda - 1000))/100)*8);
                
                Console.WriteLine("R$ " + renda.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (renda > 4500)
            {
                renda -= 2000;
                renda = (((renda - 2500)/100) * 28) + (((renda - (renda - 2500) - 1000)/100)*18) + (((renda - (renda - 2500) - 1500)/100)*8);
                Console.WriteLine("R$ " + renda.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}