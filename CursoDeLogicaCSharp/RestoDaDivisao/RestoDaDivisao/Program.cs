using System;

namespace RestoDaDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int min = numero1;
            int max = numero2;
            if (numero1>numero2)
            {
                max = numero1;
                min = numero2;
            }
            for (int i = 1; i < (max - min); i++)
            {
                if ((min + i) % 5 == 2 || (min + i) % 5 == 3) Console.WriteLine((min + i));
            }
        }
    }
}