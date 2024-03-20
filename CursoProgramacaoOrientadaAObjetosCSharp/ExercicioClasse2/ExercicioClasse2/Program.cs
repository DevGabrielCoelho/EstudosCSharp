using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ExercicioClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario(), funcionario2 = new Funcionario();
            Console.Write("Dados do primeiro funcionário:\n" +
                          "Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Dados do segundo funcionário:\n" +
                          "Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (double)(funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}