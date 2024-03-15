using System;

namespace SortSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int a, b, c, primeiro, segundo, terceiro;
            a = int.Parse(numeros[0]);
            b = int.Parse(numeros[1]);
            c = int.Parse(numeros[2]);
            if ((a > b) && (a > c))
            {
                terceiro = a;
                if (b > c)
                {
                    segundo = b;
                    primeiro = c;
                }
                else
                {
                    segundo = c;
                    primeiro = b;
                }
            }
            else if ((b > c) && (b > a))
            {
                terceiro = b;
                if (a > c)
                {
                    segundo = a;
                    primeiro = c;
                }
                else
                {
                    segundo = c;
                    primeiro = a;
                }
            }
            else
            {
                terceiro = c;
                if (a > b)
                {
                    segundo = a;
                    primeiro = b;
                }
                else
                {
                    segundo = b;
                    primeiro = a;
                }
            }
            Console.WriteLine(primeiro);
            Console.WriteLine(segundo);
            Console.WriteLine(terceiro);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}