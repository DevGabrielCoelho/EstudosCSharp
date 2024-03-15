using System;

namespace SomandoInteirosConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int numero1 = int.Parse(numeros[0]);
            int lugar = 1;
            int numero2 = int.Parse(numeros[lugar]);
            int soma = 0;
            while (numero2 <= 0)
            {
                lugar++;
                numero2 = int.Parse(numeros[lugar]);
            }
            for (int i = 0; 0 <= i && i <= numero2 -1; i++)
            {
                soma += numero1 + i;
            }
            Console.WriteLine(soma);
        }
    }
}