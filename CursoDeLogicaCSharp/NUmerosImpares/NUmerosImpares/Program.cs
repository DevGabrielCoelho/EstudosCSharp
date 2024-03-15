using System;

namespace NUmerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
        }
    }
}