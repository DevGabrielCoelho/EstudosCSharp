using System;
using System.Globalization;
using System.IO;

namespace ExercicioFixacao04
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\Estudos\CursoProgramacaoOrientadaAObjetosCSharp\ExercicioFixacao04\MyFolder\products.csv";
            string[] products = File.ReadAllLines(sourceFile);
            Directory.CreateDirectory(Path.GetDirectoryName(sourceFile).ToString() + @"\out");
            using (StreamWriter output = new(Path.GetDirectoryName(sourceFile).ToString() + @"\out\summary.csv"))
            {
                foreach (string product in products)
                {
                    string[] values = product.Split(',');
                    string name = values[0];
                    double price = double.Parse(values[1], CultureInfo.InvariantCulture);
                    int amount = int.Parse(values[2]);
                    double fullPrice = price * amount;
                    output.WriteLine($"{name},{fullPrice.ToString("f2", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}