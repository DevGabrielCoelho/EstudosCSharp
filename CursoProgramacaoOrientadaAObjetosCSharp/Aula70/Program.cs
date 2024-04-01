using System;
using System.Globalization;

namespace Aula70
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            Produto[] produto = new Produto[quantidade];
            double media = 0.0;
            for (int i = 0; i < quantidade; i++) 
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto[i] = new Produto { Nome = nome, Preco = preco };
                media += produto[i].Preco;
            }
            media /= (double)quantidade;
            Console.WriteLine($"Preço médio dos produtos: {media.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}