using System;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] quartos = new Quartos[10];
            Console.Write("Quantos quartos serão alugados? ");
            int quantidadeDePessoas = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeDePessoas; i++)
            {
                Console.Write($"\nPedido #{i+1}:\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int numeroDoQuarto = int.Parse(Console.ReadLine());
                quartos[numeroDoQuarto] = new Quartos { Nome = nome, Email = email };
            }

            Console.WriteLine("\nQuartos comprados:");
            for (int i = 0; i < quartos.Length; i++) 
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i].Nome}, {quartos[i].Email}");
                }
            }
        }
    }
}