using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using Entities;
using Services;

namespace ExercicioFixacao05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter contract data\n" +
                              "Number: ");
                int numberContract = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime dateContract = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("\nEnter number of installments: ");
                int installmentsCount = int.Parse(Console.ReadLine());

                Entities.Contract contract = new(numberContract, dateContract, valueContract);
                PaymentService paymentService = new(new IPaypalTax());
                paymentService.PaymentServices(contract, installmentsCount);
                Console.WriteLine("Installments:");
                foreach(Installment installment in contract.Installments)
                {
                    Console.WriteLine(installment);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}