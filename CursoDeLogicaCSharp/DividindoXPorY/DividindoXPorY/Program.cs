using System;
using System.Globalization;

namespace DividindoXPorY
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double valor1 = int.Parse(valores[0], CultureInfo.InvariantCulture);
                double valor2 = int.Parse(valores[1], CultureInfo.InvariantCulture);
                if (valor2 == 0) Console.WriteLine("divisao impossivel");
                else Console.WriteLine((valor1 / valor2).ToString("f1", CultureInfo.InvariantCulture));
            }
        }
    }
}