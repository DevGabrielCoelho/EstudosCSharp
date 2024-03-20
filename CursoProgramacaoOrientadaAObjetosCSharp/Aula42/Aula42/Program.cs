using System;
using System.Globalization;

namespace Aula42
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto produto = new Produto();

            Console.Write("Digite os dados do produto:\n" +
                          "Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(quantidade);

            Console.WriteLine($"Dados do atualizados: {produto}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProduto(quantidade);

            Console.WriteLine($"Dados do atualizados: {produto}");

        }
    }
}