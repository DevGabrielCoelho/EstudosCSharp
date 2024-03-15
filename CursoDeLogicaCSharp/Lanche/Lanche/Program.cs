using System;
using System.Globalization;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(' ');
            double f = double.Parse(x[0], CultureInfo.InvariantCulture);

            switch (int.Parse(x[0])) 
            {
                case 1:
                    f = 4.00;
                    break;
                case 2:
                    f = 4.50;
                    break;
                case 3:
                    f = 5.00;
                    break;
                case 4:
                    f = 2.00;
                    break;
                case 5:
                    f = 1.50;
                    break;
                default:
                    Console.WriteLine("NUMERO INVALIDO");
                    break;
            }
            double conta = double.Parse(x[1], CultureInfo.InvariantCulture) * f;
            Console.WriteLine("Total: R$ " + conta.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}