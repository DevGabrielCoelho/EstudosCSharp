using System;
using System.Globalization;

namespace esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cal = (double) ((4.0 / 3.0) * 3.14159 )* Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + cal.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}