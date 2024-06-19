using System;
using System.Globalization;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[100];
            double input = double.Parse(Console.ReadLine());
            vetor[0] = input;
            for (int i = 1; i < vetor.Length; i++) 
            {
                vetor[i] = vetor[i-1]/2;
            }
            for (int i = 0;i < vetor.Length; i++) 
            {
                Console.WriteLine($"N[{i}] = {vetor[i].ToString("0.0000")}");
            }
        }
    }
}