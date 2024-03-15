using System;

namespace ParesEntreCincoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, valor5, total;
            total = 0;
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            valor3 = int.Parse(Console.ReadLine());
            valor4 = int.Parse(Console.ReadLine());
            valor5 = int.Parse(Console.ReadLine());

            if (((Math.Abs(valor1)) %2) == 0)
            {
                total += 1;
            }
            if (((Math.Abs(valor2)) %2) == 0)
            {
                total += 1;
            }
            if (((Math.Abs(valor3)) %2) == 0)
            {
                total += 1;
            }
            if (((Math.Abs(valor4)) %2) == 0)
            {
                total += 1;
            }
            if (((Math.Abs(valor5)) %2) == 0)
            {
                total += 1;
            }
            Console.WriteLine(total + " valores pares");
        }
    }
}