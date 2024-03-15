using System;
using System.Globalization;

namespace NotasEMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int cen = (int)(quant / 100);
            int cinq = (int)(quant % 100) / 50;
            int vint = (int)((quant % 100) % 50) / 20;
            int dez = (int)(((quant % 100) % 50) % 20) / 10;
            int cinc = (int)((((quant % 100) % 50) % 20) % 10) / 5;
            int dois = (int)(((((quant % 100) % 50) % 20) % 10) % 5) / 2;
            int um = (int)(((((quant % 100) % 50) % 20) % 10) % 5) % 2;
            double cent = (double)(((((((quant % 100) % 50) % 20) % 10) % 5) % 2) %1) / 0.50;
            double vinc = (double)((((((((quant % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) / 0.25;
            double dezc = (double)(((((((((quant % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) % 0.25) / 0.10;
            double cincent = (double)((((((((((quant % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) % 0.25) % 0.10) / 0.05;
            double umc = (double)(((((((((((quant % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) % 0.25) % 0.10) % 0.05) / 0.01;
            Console.WriteLine("NOTAS:");
            Console.WriteLine(cen + " nota(s) de R$ 100.00");
            Console.WriteLine(cinq + " nota(s) de R$ 50.00");
            Console.WriteLine(vint + " nota(s) de R$ 20.00");
            Console.WriteLine(dez + " nota(s) de R$ 10.00");
            Console.WriteLine(cinc + " nota(s) de R$ 5.00");
            Console.WriteLine(dois + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine((int)um + " moeda(s) de R$ 1.00");
            Console.WriteLine((int)cent + " moeda(s) de R$ 0.50");
            Console.WriteLine((int)vinc + " moeda(s) de R$ 0.25");
            Console.WriteLine((int)dezc + " moeda(s) de R$ 0.10");
            Console.WriteLine((int)cincent + " moeda(s) de R$ 0.05");
            Console.WriteLine((int)umc + " moeda(s) de R$ 0.01");
        }
    }
}