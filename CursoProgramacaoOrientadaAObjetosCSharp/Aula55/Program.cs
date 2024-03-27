using System;
using System.Globalization;

namespace Aula51
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV",4000.00, 10);
            
            produto.SetNome(Console.ReadLine());

            Console.WriteLine($"\n{produto.GetNome()}\n");
            Console.WriteLine(produto);
        }
    }
}