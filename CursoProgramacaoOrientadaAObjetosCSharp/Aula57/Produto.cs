using System.Globalization;

namespace Aula57
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }   //                //
                                                   // AUTO PROPERTIE //
                                                  //                //
        public int Quantidade { get; private set; }

        public Produto()
        {
            Preco = 5;
            Quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade)   //            //
        {                                                          // CONSTRUTOR //
            _nome = nome;                                         //            //
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)   //            // 
        {                                          // SOBRECARGA //
            _nome = nome;                         //            //
            Preco = preco;
        }
        public Produto(string nome) : this()                 //                                                      //
        {                                                   // TEST COM THIS (REFERENCIANDO UM CONSTRUTOR EM OUTRO) //
            _nome = nome;                                  //                                                      //
        }

        public string Nome
        {
            get { return _nome; }
            set
            {                                             //                                                                     //
                if (value != null && value.Length > 1)   // PARAMETRO DE PROPRIEDADE PARA MODIFICAR OU ENVIAR UM OBJETO PRIVADO //
                {                                       //                                                                     //
                    _nome = value;
                }
            }
        }

        public void SetNome(string nome)           //                                                              //
        {                                         // PARAMETRO QUE NÃO RETORNA VALOR E MODIFICA UM OBJETO PRIVADO //
            if (nome != null && nome.Length > 1) //                                                              //
            {
                _nome = nome;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()   //            //
        {                                  // FORMATAÇÃO //
            return _nome                  //            //
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}