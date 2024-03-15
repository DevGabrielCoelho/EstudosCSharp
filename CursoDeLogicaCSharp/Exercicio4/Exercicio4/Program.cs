using System;
using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(' ');
            string[] y = Console.ReadLine().Split(' ');
            double med = (double) (int.Parse(x[1]) + int.Parse(y[1]))/2.0;
            Console.WriteLine("A idade média de " + x[0] + " e " + y[0] + " é de " +  
                med.ToString(CultureInfo.InvariantCulture) + " anos");
        }
    }
}