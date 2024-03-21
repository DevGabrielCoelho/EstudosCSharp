using System;
using System.Globalization;

namespace ExercicioStatic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você quer comprar? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); double reais = Calc.Calcular(cotacao, compra);
            Console.WriteLine($"Valor a ser pago em reais: {Calc.Calcular(cotacao, compra).ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}