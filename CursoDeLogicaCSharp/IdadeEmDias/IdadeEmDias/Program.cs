using System;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int quant = int.Parse(Console.ReadLine());
            int anos = quant / 365;
            int meses = (quant % 365)/30;
            int dias = (quant % 365) % 30;
            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}