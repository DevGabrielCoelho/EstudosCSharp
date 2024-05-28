using Entities;
using System;
using System.Globalization;
using System.Linq;

namespace ExercicioProposto04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full file path: ");
            using (StreamReader streamReader = File.OpenText(Console.ReadLine()))
            {
                while (!streamReader.EndOfStream)
                {
                    string[] stringSplit = streamReader.ReadLine().Split(',');
                    employees.Add(
                        new Employee(
                            stringSplit[0],
                            stringSplit[1],
                            double.Parse(stringSplit[2], CultureInfo.InvariantCulture)
                        )
                    );
                }
            }

            Console.Write("\nEnter salary: $");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IEnumerable<string> emailsMoreThanSalary = employees.
                Where(emp => emp.Salary > salary).
                Select(emp => emp.Email).
                OrderBy(emp => emp);
            foreach ( string email in emailsMoreThanSalary ) Console.WriteLine(email);

            double sum = employees.Where(emp => emp.Name[0] == 'M').Sum(emp => emp.Salary);
            Console.WriteLine($"\nSum of salary of people whose name starts with 'M': ${sum.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}