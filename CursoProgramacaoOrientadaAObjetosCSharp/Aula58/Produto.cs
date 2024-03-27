using System.Globalization;

namespace Aula58
{
    class Produto
    {
        /* COMO ORGANIZAR UMA CLASSE:
         * ATRIBUTOS PRIVADOS
         * PROPRIEDADES AUTOIMPLEMENTADAS
         * CONSTRUTORES
         * PROPRIEDADES CUSTOMIZADAS
         * OUTROS METODOS DA CLASSSE */

        private string _nome;                                                   //                    //
                                                                               // ATRIBUTOS PRIVADOS //
                                                                              //                    //

        //=======================================================================================================================================================//

        public double Preco { get; private set; }                               //                 //
                                                                               // AUTO PROPERTIES //
                                                                              //                 //
        public int Quantidade { get; private set; }

        //=======================================================================================================================================================//

        public Produto()                                                        //             //
        {                                                                      // CONTRUTORES //
            Preco = 5;                                                        //             //
            Quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade)  
        {                                                          
            _nome = nome;                                        
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)    
        {                                          
            _nome = nome;                         
            Preco = preco;
        }
        public Produto(string nome) : this()                 
        {                                                  
            _nome = nome;                                 
        }

        //=======================================================================================================================================================//

        public string Nome                                                      //                   //
        {                                                                      // CUSTOM PROPERTIES //
            get { return _nome; }                                             //                   //
            set
            {                                         
                if (value != null && value.Length > 1)
                {                                     
                    _nome = value;
                }
            }
        }

        //=======================================================================================================================================================//

        public double ValorTotalEmEstoque()                                     //                          //
        {                                                                      // OUTROS METODOS DE CLASSE //
            return Preco * Quantidade;                                        //                          //
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()  
        {                                  
            return _nome                  
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}