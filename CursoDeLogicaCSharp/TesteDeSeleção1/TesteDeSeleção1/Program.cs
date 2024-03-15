using System;

namespace TesteDeSeleção1
{
    class Program
    {
        static void Main(string[] args) 
        {
            int a, b, c, d;
            string[] x = Console.ReadLine().Split(' ');
            a = int.Parse(x[0]);
            b = int.Parse(x[1]);
            c = int.Parse(x[2]);
            d = int.Parse(x[3]);

            if ((b > c && d > a) && ((c + d) > (a + b)) && (c > 0 && d > 0) && ((a%2) == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}