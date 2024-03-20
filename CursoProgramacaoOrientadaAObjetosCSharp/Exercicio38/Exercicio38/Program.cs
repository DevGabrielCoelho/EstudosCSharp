using System;
using System.Globalization;

namespace Exercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo(), y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x.Area() > y.Area()) Console.WriteLine("A Area de X é a Maior");
            else Console.WriteLine("A Area de Y é a Maior");
        }
    }
}