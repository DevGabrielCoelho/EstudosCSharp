using System;
using System.Globalization;

namespace SequenciaS
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            for (int i = 1; i <= 100; i++)
            {
                s += ((double) 1 / i);
            }
            Console.WriteLine(s.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}