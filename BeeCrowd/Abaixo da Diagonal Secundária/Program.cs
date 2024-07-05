using System;

namespace BeeCownd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1  2  3  4  5
             6  7  8  9  10
             11 12 13 14 15
             16 17 18 19 20
             21 22 23 24 25
             */
            double[,] doubles = new double[5, 5];
            char sm = char.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    doubles[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double sum = 0.0;
            double med = 0.0;
            for (int i = 4; i >= 0; i--)
            {
                int count = 1;
                for (int j = 4; j >= count; j--)
                {
                    sum += doubles[i, j];
                    med++;
                }
                count++;
            }
            med = sum / med;
            if (sm == 'S') Console.WriteLine(sum.ToString("f1"));
            else Console.WriteLine(med.ToString("f1"));

        }
    }
}