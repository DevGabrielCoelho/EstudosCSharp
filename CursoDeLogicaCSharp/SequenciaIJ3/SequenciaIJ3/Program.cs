using System;

namespace SequenciaIJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 7;
            for (int i = 1; i <=9; i++)
            {
                if (i % 2 != 0)
                {
                    int numeroini = numero;
                    for (int o = 1; o <= 3; o++)
                    {
                        Console.WriteLine("I=" + i + " J=" + numero);
                        numero -= 1;
                    }
                    numero = numeroini + 2;
                }
            }
        }
    }
}