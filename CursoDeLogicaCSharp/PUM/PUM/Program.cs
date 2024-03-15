using System;

namespace PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int x = 1;
            int y = 2;
            int z = 3;
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine(x + " " + y + " " + z + " PUM");
                x = z + 2;
                y = x + 1;
                z = y + 1;
            }
        }
    }
}