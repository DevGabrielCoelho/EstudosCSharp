using System;
using System.IO;

namespace Aula195
{
    class Program
    {
        static void Main(string[] args) 
        {
            FileInfo file = new FileInfo(@"Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula195\TextTest01.txt");
            file.CopyTo(@"Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula195\TextTest02.txt");
            string[] textLines = File.ReadAllLines(@"Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula195\TextTest02.txt");
            foreach (string line in textLines) 
            {
                Console.WriteLine(line);
            }
        }
    }
}