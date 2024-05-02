using System;
using System.IO;

namespace Aula195
{
    class Program
    {
        static void Main(string[] args) 
        {
            FileInfo file = new FileInfo("https://github.com/NUBsGP/NUBsGP/blob/main/README.md");
            file.CopyTo(@"C:\Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula195\TextTest02.txt");
            string[] textLines = File.ReadAllLines(@"C:\Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula195\TextTest02.txt");
            foreach (string line in textLines) 
            {
                Console.WriteLine(line);
            }
        }
    }
}