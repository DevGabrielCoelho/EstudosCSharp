using System;

namespace Aula66
{
    class Program
    {
        static void Main(string[] args)
        {
            PontoCartesiano PontoCartesiano;
            PontoCartesiano.x = double.Parse(Console.ReadLine());
            PontoCartesiano.y = double.Parse(Console.ReadLine());

            Console.WriteLine(PontoCartesiano);
            PontoCartesiano = new PontoCartesiano();
            Console.WriteLine(PontoCartesiano);
        }
    }
}