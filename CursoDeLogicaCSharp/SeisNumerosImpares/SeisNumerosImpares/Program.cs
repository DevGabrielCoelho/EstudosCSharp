using System;

namespace SeisNumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, impar1, impar2, impar3, impar4, impar5, impar6;
            numero = int.Parse(Console.ReadLine());
            if ((numero % 2) == 0)
            {
                impar1 = numero + 1;
                impar2 = impar1 + 2;
                impar3 = impar2 + 2;
                impar4 = impar3 + 2;
                impar5 = impar4 + 2;
                impar6 = impar5 + 2;
            }
            else
            {
                impar1 = numero;
                impar2 = impar1 + 2;
                impar3 = impar2 + 2;
                impar4 = impar3 + 2;
                impar5 = impar4 + 2;
                impar6 = impar5 + 2;
            }
            Console.WriteLine(impar1);
            Console.WriteLine(impar2);
            Console.WriteLine(impar3);
            Console.WriteLine(impar4);
            Console.WriteLine(impar5);
            Console.WriteLine(impar6);
        }
    }
}