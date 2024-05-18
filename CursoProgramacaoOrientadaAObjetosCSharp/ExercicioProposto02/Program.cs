using System;
using Entities;

namespace ExercicioProposto02
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> courseRegistrationA = new HashSet<Student>();
            HashSet<Student> courseRegistrationB = new HashSet<Student>();
            HashSet<Student> courseRegistrationC = new HashSet<Student>();
            try
            {
                Console.Write("\nHow many students for course A? ");
                int loopCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < loopCount; i++)
                {
                    Console.Write($"Enter registration for student #{i + 1}: ");
                    courseRegistrationA.Add(new Student(int.Parse(Console.ReadLine())));
                }

                Console.Write("\nHow many students for course B? ");
                loopCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < loopCount; i++)
                {
                    Console.Write($"Enter registration for student #{i + 1}: ");
                    courseRegistrationB.Add(new Student(int.Parse(Console.ReadLine())));
                }

                Console.Write("\nHow many students for course C? ");
                loopCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < loopCount; i++)
                {
                    Console.Write($"Enter registration for student #{i + 1}: ");
                    courseRegistrationC.Add(new Student(int.Parse(Console.ReadLine())));
                }
                HashSet<Student> total = new HashSet<Student>(courseRegistrationA);
                total.UnionWith(courseRegistrationB);
                total.UnionWith(courseRegistrationC);
                Console.WriteLine($"\nTotal students: {total.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}!");
            }
        }
    }
}