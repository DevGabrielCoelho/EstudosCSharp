using System;
using System.Globalization;

namespace ExercicioConstrutoresEncapsulamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositarInicial = 0;
            Console.Write("Entre o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                depositarInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta conta = new Conta(numeroDaConta, nome, depositarInicial);

            Console.WriteLine($"\nDados da conta:\n{conta}\n");

            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados atualizados:\n{conta}\n");
            
            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados atualizados:\n{conta}");
        }
    }
}