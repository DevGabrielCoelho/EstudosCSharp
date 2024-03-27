using System;
using System.Globalization;

namespace Aula58
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 4000.00, 10);

            produto.Nome = (Console.ReadLine());

            Console.WriteLine($"{produto.Nome}");
            Console.WriteLine($"{produto.Preco}");
            Console.WriteLine($"{produto.Quantidade}");
            Console.WriteLine(produto);
        }
    }
}