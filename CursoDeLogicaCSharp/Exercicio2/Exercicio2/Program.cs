using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Largura do Terreno:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o Comprimento do Terreno:");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o Preço do Metro Quadrado:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double total = area * valor;

            Console.WriteLine("ARREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = $" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}