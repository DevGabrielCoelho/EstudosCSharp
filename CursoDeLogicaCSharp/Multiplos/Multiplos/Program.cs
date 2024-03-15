using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string[] x = Console.ReadLine().Split(' ');
            a = int.Parse(x[0]);
            b = int.Parse(x[1]);
            if (((a%b) == 0) || ((b%a) == 0))
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}