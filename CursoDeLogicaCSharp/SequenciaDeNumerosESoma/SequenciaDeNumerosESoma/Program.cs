using System;

namespace SequenciaDeNumerosESoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, min, max, soma;
            string[] numeros = Console.ReadLine().Split(' ');
            numero1 = int.Parse(numeros[0]);
            numero2 = int.Parse(numeros[1]);
            while (numero1 > 0 && numero2 > 1)
            {
                min = numero1;
                max = numero2;
                soma = 0;
                if (numero1 > numero2)
                {
                    min = numero2;
                    max = numero1;
                }
                for (min += 0; min <= max; min++)
                {
                    Console.Write(min + " ");
                    soma += min;
                }
                Console.WriteLine("Sum=" + soma);
                numeros = Console.ReadLine().Split(' ');
                numero1 = int.Parse(numeros[0]);
                numero2 = int.Parse(numeros[1]);
            }
        }
    }
}