using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] nomes = new string[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                nomes[i] = Console.ReadLine();
            }

            foreach (string elemento in nomes)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}