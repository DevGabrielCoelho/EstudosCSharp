using Aula135.Entities;
using System;
using System.Globalization;

namespace Aula135
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount businessAccount = new BusinessAccount(1234, "Bob", 2000, 2000);
            Console.Write($"{businessAccount}\n" +
                           "Loan value: ");
            businessAccount.Loan(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write($"{businessAccount}\n" +
                           "Loan value: ");
            businessAccount.Loan(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));


        }
    }
}