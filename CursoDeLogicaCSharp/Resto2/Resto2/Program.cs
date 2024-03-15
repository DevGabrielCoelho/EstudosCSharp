using System;

namespace Resto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 2; i < 10000; i++)
            {
                if (i % numero == 2) Console.WriteLine(i);
            }
        }
    }
}