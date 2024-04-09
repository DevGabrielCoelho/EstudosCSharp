using ExercicioResolvido01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace ExercicioResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new();
            Console.Write("Enter the number of employees: ");
            int employeeQuantity = int.Parse(Console.ReadLine());


            for (int i = 0; i < employeeQuantity; i++)
            {
                Console.Write($"\nEmployee #{i + 1} data:\n" +
                              "Outsourced (y/n)? ");
                char outsourceQuestion = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string employeeName = Console.ReadLine();
                Console.Write("Hours: ");
                int employeeHours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourceQuestion == 'y' || outsourceQuestion == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double outsourceAddCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourceEmployee(employeeName, employeeHours, employeeValuePerHour, outsourceAddCharge));
                }
                else
                {
                    employees.Add(new Employee(employeeName, employeeHours, employeeValuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - ${employee.Payment().ToString("f2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}