using System;

namespace SequenciaLogica2
{
    class Program
    {
        static void Main(string[] args) 
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int numero1 = int.Parse(numeros[0]);
            int numero2 = int.Parse(numeros[1]);
            for (int i = 1; i <= numero2; i++)
            {
                if (i % numero1 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i == numero2) Console.WriteLine(i);
                else Console.Write(i + " ");
            }
        }
    }
}