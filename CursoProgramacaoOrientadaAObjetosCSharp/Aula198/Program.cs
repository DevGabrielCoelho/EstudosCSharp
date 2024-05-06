using System;
using System.IO;

namespace Aula198
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula198\TextTest01.txt";
            string path2 = @"Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula198\TextTest02.txt";

            try
            {
                string[] strings = File.ReadAllLines(path1);
                using (StreamWriter streamWriter = File.AppendText(path2))
                {
                    foreach (string s in strings) 
                    {
                        streamWriter.WriteLine(s);
                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}