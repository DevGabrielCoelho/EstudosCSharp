using System;
using System.Globalization;

namespace Experiencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int r = 0;
            int s = 0;
            int total = 0;
            int repeticoes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= repeticoes; i++)
            {
                string[] experimento = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(experimento[0]);
                char tipo = char.Parse(experimento[1]);
                if (tipo == 'C') c += quantidade;
                else if (tipo == 'R') r += quantidade;
                else if (tipo == 'S') s += quantidade;
                total += quantidade;
            }
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + c);
            Console.WriteLine("Total de ratos: " + r);
            Console.WriteLine("Total de sapos: " + s);
            Console.WriteLine("Percentual de coelhos: " + ((double)(c * 100) / total).ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + ((double)(r * 100) / total).ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + ((double)(s * 100) / total).ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}