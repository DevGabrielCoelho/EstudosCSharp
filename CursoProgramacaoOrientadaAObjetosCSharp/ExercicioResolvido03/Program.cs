using System;
using System.Globalization;
using ExercicioResolvido03.Entities;
using ExercicioResolvido03.Entities.Enums;

namespace ExercicioResolvido03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int shapeQuantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < shapeQuantity; i++)
            {
                Console.Write($"\nShape #{i + 1} data:\n" +
                               "Rectangle or Circle (r/c)? ");
                char rectCircQuestion = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color colorQuestion = Color.Parse<Color>(Console.ReadLine());
                if (rectCircQuestion == 'c' || rectCircQuestion == 'C')
                {
                    Console.Write("Radius: ");
                    double circRadius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(colorQuestion, circRadius));
                }
                else
                {
                    Console.Write("Width: ");
                    double rectWidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double rectHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(colorQuestion, rectWidth, rectHeight));
                }
            }

            Console.WriteLine($"\nSHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}