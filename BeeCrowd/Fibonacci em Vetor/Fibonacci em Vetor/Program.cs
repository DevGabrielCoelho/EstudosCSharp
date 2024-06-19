using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                ulong sum = 1;
                ulong anterior = 0;
                for (int j = 1; j < input; j++)
                {
                    ulong backup = sum;
                    sum += anterior;
                    anterior = backup;
                }
                if (input == 0) Console.WriteLine("Fib(0) = 0");
                else if (input == 1) Console.WriteLine("Fib(1) = 1");
                else Console.WriteLine($"Fib({input}) = {sum}");
            }
        }
    }
}