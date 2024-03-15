using System;

namespace cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int quant = int.Parse(Console.ReadLine());
            int cen = quant / 100;
            int cinq = (quant % 100) / 50;
            int vin = ((quant % 100) % 50) / 20; 
            int dez = (((quant % 100) % 50) % 20) / 10;
            int cinc = ((((quant % 100) % 50) % 20) % 10) / 5;
            int dois = (((((quant % 100) % 50) % 20) % 10) % 5) / 2;
            int um = ((((((quant % 100) % 50) % 20) % 10) % 5) % 2) / 1;
            Console.WriteLine(quant);
            Console.WriteLine(cen + " nota(s) de R$ 100,00");
            Console.WriteLine(cinq + " nota(s) de R$ 50,00");
            Console.WriteLine(vin + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinc + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");
        }
    }
}