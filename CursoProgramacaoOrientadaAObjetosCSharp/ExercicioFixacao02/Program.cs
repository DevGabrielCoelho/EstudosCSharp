using ExercicioFixacao02.Entities;
using System;
using System.Globalization;

namespace ExercicioFixacao02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonShape> persons = new List<PersonShape>();
            Console.Write("Enter the number of tax payers: ");
            int taxPayersQuantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < taxPayersQuantity; i++)
            {
                Console.Write($"\nTax payer #{i + 1} data:\nIndividual or company (i/c)? ");
                char indiCompQuestion = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string payerName = Console.ReadLine();
                Console.Write("Anual income: ");
                double payerAnnualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (indiCompQuestion == 'i' || indiCompQuestion == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double helthCost = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    persons.Add(new Individual(payerName, payerAnnualIncome, helthCost));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employeesQuantity = int.Parse(Console.ReadLine());
                    persons.Add(new Company(payerName, payerAnnualIncome, employeesQuantity));
                }
            }
            Console.WriteLine("\nTAXES PAID: ");
            foreach (PersonShape person in persons)
            {
                Console.WriteLine($"{person.Name}: ${person.IncomeTax().ToString("f2", CultureInfo.InvariantCulture)}");
            }

            Console.Write("\nTOTAL TAXES: ");
            double totalTaxes = 0.0;
            foreach (PersonShape person in persons)
            {
                totalTaxes += person.IncomeTax();
            }
            Console.WriteLine(totalTaxes.ToString("f2", CultureInfo.InvariantCulture));
            
        }
    }
}