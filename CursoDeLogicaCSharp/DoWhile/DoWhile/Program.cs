using System;
using System.Globalization;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string repetir;
            double c, f;
            do
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = ((9 * c) / 5) + 32;
                Console.WriteLine(f.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n): ");
                repetir = Console.ReadLine();
            } while (repetir == "s");
        }
    }
}