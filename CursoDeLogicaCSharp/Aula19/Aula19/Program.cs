using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double a, b, c;

            a = Math.Sqrt(x);
            b = Math.Sqrt(y);
            c = Math.Sqrt(25.0);
            Console.WriteLine("A Raiz Quadrada de " + x + " = " + a);
            Console.WriteLine("A Raiz Quadrada de " + y + " = " + b);
            Console.WriteLine("A Raiz Quadrada de 25 = " + c);

            a = Math.Pow(x, y);
            b = Math.Pow(x, 2.0);
            c = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + a);
            Console.WriteLine(x + " elavado a 2 = " + b);
            Console.WriteLine("5 elevado a 2 = " + c);

            a = Math.Abs(y);
            b = Math.Abs(z);
            Console.WriteLine("O valor absoluto de " + y + " = " + a);
            Console.WriteLine("O valor absoluto de " + z + " = " + b);
        }
    }
}