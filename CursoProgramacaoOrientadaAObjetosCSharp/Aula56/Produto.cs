using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Aula56
{
    class Produto
    {
        private string _nome;      //                 //
        private double _preco;    // OBJETO PRIVADAS //
        private int _quantidade; //                 //

        public Produto()
        {
            _preco = 5;
            _quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade)   //            //
        {                                                          // CONSTRUTOR //
            _nome = nome;                                         //            //
            _preco = preco;
            _quantidade = quantidade;
        }
        public Produto(string nome, double preco)   //            // 
        {                                          // SOBRECARGA //
            _nome = nome;                         //            //
            _preco = preco;
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

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
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
            return _preco * _quantidade;    
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()   //            //
        {                                  // FORMATAÇÃO //
            return _nome                  //            //
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}