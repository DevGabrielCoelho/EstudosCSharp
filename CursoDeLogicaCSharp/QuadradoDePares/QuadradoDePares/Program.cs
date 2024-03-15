using System;

namespace QuadradoDePares
{
    class Prgram
    {
        static void Main(string[] args)
        {
            int elevado = 0;
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    elevado = (int) Math.Pow(i, 2);
                    Console.WriteLine(i + "^2 = " + elevado);
                }
            }
        }
    }
}