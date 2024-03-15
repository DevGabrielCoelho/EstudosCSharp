using System;

namespace SequenciaLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine(i + " " + (Math.Pow(i, 2)) + " " + (Math.Pow(i, 2) * i));
                Console.WriteLine(i + " " + (Math.Pow(i, 2) + 1)  + " " + (Math.Pow(i, 2) * i + 1));

            }
        }
    }
}