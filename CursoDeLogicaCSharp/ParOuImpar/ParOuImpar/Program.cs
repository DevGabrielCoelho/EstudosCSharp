using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                int numeros = int.Parse(Console.ReadLine());
                if (numeros % 2 == 0 && numeros != 0) Console.Write("EVEN ");
                else if (numeros % 2 != 0) Console.Write("ODD ");
                if (numeros == 0) Console.WriteLine("NULL");
                else if (numeros > 0) Console.WriteLine("POSITIVE");
                else if (numeros < 0) Console.WriteLine("NEGATIVE");
            }
        }
    }
}