using System;

namespace FatorialSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int anterior = 0;
            int numero = int.Parse(Console.ReadLine());
            if (numero == 1) Console.WriteLine(numero);
            else
            {
                for (int i = 1; i < numero; i++)
                {
                    if (i == 1)
                    {
                        anterior = numero * (numero - i);
                        
                    }
                    else if (i > 1)
                    {
                        anterior = anterior * (numero - i);
                    }
                }
                Console.WriteLine(anterior);
            }
        }
    }
}