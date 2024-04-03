using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int id; string nome; double salario;
            Console.Write("Quantos funcionarios registrados? ");
            int quantidadeDeFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();



            for (int i = 0; i < quantidadeDeFuncionarios; i++)
            {
                Console.Write($"\nFuncionario #{i + 1}\nInsira o ID do funcionario: ");
                do
                {
                    id = int.Parse(Console.ReadLine());
                } while (funcionarios.Exists(x => x.Id == id) == true);

                Console.Write("Insira o nome do funcionario: ");
                nome = Console.ReadLine();

                Console.Write("Insira o salário do funcionario: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));

            }

            Console.Write("\nQual o ID do funcionario que terá aumento salarial? ");
            int idDoFuncionario = int.Parse(Console.ReadLine());
            if ((funcionarios.Exists(x => x.Id == idDoFuncionario) == true))
            {
                Console.Write("Qual a porcentagem de aumento ele receberá? ");
                double porcentagemDeAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario funcionarios2 = funcionarios.Find(x => x.Id == idDoFuncionario);
                
                funcionarios2.AumentarSalario(porcentagemDeAumento);
            }
            else Console.WriteLine("\nEsse ID não existe!");

            

            Console.WriteLine($"\nLista atualizada de funcionarios");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.Write(funcionario);
            }
        }
    }
}