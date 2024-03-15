using System;

namespace Exercicio4903
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i != 11; i++)
            {
                Console.WriteLine(i + " x " + numero + " = " + (numero * i));
            }
        }
    }
}