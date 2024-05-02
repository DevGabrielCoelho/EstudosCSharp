using System;

namespace Aula213
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many values? ");
                int valuesQuantity = int.Parse(Console.ReadLine());
                PrintService<int> printService = new ();
                for (int i = 0; i < valuesQuantity; i++) printService.AddValue(int.Parse(Console.ReadLine()));
                printService.Print();
                Console.WriteLine($"First: {printService.First()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}