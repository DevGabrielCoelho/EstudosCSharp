using System;
using System.Runtime.Serialization;

namespace UltrapassandoZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero2;
            int numero1 = int.Parse(Console.ReadLine());
            do
            {
                numero2 = int.Parse(Console.ReadLine());
            } while (numero2 <= numero1);
            int numero = numero1;
            int contagem = 1;
            for (int i = 1; numero <= numero2; i++)
            {
                numero = numero + numero1 + i;
                contagem++;
            }
            Console.WriteLine(contagem);
        }
    }
}