using System;
using System.Globalization;

namespace SequenciaSII
{
    class Program
    {
        static void Main(string[] args)
        {
            double par = 2.0;
            double s = 1.0;
            for (double i = 3.0; i <= 39.0; i++)
            {
                if (i % 2 != 0)
                {
                    s += ((double) i / par);
                    par *= 2.0;
                }
            }
            Console.WriteLine(s.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}