using System;

namespace SomaDParesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                if ((numero % 2) == 0)
                {
                    numero = numero + (numero + 2) + (numero + 4) + (numero + 6) + (numero + 8);
                    Console.WriteLine(numero);
                }
                else
                {
                    numero += 1;
                    numero = numero + (numero + 2) + (numero + 4) + (numero + 6) + (numero + 8);
                    Console.WriteLine(numero);
                }
                numero = int.Parse(Console.ReadLine());
            }
        }
    }
}