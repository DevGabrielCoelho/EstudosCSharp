using System;

namespace ExercicioClasse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa nome = new Pessoa(), idade = new Pessoa(), 
                   nome2 = new Pessoa(), idade2 = new Pessoa();
            
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            nome.A = Console.ReadLine();
            Console.Write("Idade: ");
            idade.B = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome2.A = Console.ReadLine();
            Console.Write("Idade: ");
            idade2.B = int.Parse(Console.ReadLine());

            if (idade.B > idade2.B) Console.WriteLine("Pessoa mais velha: " + nome.A);
            else Console.WriteLine("Pessoa mais velha: " + nome2.A);
            
        }
    }
}