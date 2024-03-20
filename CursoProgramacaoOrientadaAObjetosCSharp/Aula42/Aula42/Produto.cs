using System.Globalization;

namespace Aula42
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return $"{Nome}, ${Preco.ToString("f2", CultureInfo.InvariantCulture)}, {Quantidade}unidades, " +
                   $"{ValorTotal().ToString("f2", CultureInfo.InvariantCulture)}";
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }


    }
}
