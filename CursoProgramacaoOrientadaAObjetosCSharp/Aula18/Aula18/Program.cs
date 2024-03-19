using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Aula18
{
    class Program
    {
        
        static void Main(string[] args)
            
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escrotório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'm';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine($"Produtos:\n" +
                $"{produto1}, cujo o preço é ${preco1}\n" +
                $"{produto2}, cujo preço é ${preco2}\n\n" +
                $"Registro: {idade} anos de idade, código {codigo} e gênero {genero}\n\n" +
                $"Medida com oito casas decimais: {media:f8}\n" +
                $"Arredondado (três casas decimais): {media:f3}\n" +
                $"Separador decimal invariant culture: {media.ToString("f3", CultureInfo.InvariantCulture)}");
            
        }
        
        public void Menu(string[] args) 
        {
            
            string produto1 = "Computador";
            string produto2 = "Mesa de escrotório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'm';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine($"Produtos:\n" +
                $"{produto1}, cujo o preço é ${preco1}\n" +
                $"{produto2}, cujo preço é ${preco2}\n\n" +
                $"Registro: {idade} anos de idade, código {codigo} e gênero {genero}\n\n" +
                $"Medida com oito casas decimais: {media:f8}\n" +
                $"Arredondado (três casas decimais): {media:f3}\n" +
                $"Separador decimal invariant culture: {media.ToString("f3", CultureInfo.InvariantCulture)}");

        }
    }
}