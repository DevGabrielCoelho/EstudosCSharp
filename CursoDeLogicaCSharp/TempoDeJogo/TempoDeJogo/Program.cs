using System;

namespace TempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, total;
            string[] x = Console.ReadLine().Split(' ');
            a = int.Parse(x[0]);
            b = int.Parse(x[1]);
            if ((a == 0 && b == 0) || (a == 24 && b == 0) || (a == 24 && b == 0) || (a == 24 && b == 24) || (a == b))
            {
                total = 24;
            }
            else if (a > b)
            {
                total = (24 - a) + b;
            }
            else
            {
                total = b - a;
            }
            Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
        }
    }
}