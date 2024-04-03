using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioListas
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagemDeAumento)
        {
            Salario += (Salario / 100 * porcentagemDeAumento);
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario.ToString("f2", CultureInfo.InvariantCulture)}\n";
        }

    }
}
