using System;
using System.Globalization;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double novosalario = 0;
            double reajuste = 0;
            int porcentagem = 0;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (salario <= 400.00)
            {
                porcentagem = 15;
                reajuste = (double)(salario/100.00)*porcentagem;
                novosalario = reajuste + salario;
            }
            else if (salario <= 800.00)
            {
                porcentagem = 12;
                reajuste = (double)(salario / 100.00) * porcentagem;
                novosalario = reajuste + salario;
            }
            else if (salario <= 1200.00)
            {
                porcentagem = 10;
                reajuste = (double)(salario / 100.00) * porcentagem;
                novosalario = reajuste + salario;
            }
            else if (salario <= 2000.00)
            {
                porcentagem = 7;
                reajuste = (double)(salario / 100.00) * porcentagem;
                novosalario = reajuste + salario;
            }
            else if (salario > 2000.00)
            {
                porcentagem = 4;
                reajuste = (double)(salario / 100.00) * porcentagem;
                novosalario = reajuste + salario;
            }
            else
            {
                Console.WriteLine("Valor Invalido");
            }
            Console.WriteLine("Novo salario: " + novosalario.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + porcentagem + " %");
        }
    }
}