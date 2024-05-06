using System;
using System.IO;

namespace Aula196
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new(@"Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula196\TextTest01.txt", FileMode.Open);
                streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream)
                {
                    string text = streamReader.ReadLine();
                    Console.WriteLine(text);
                } 
            }
            catch (IOException ex) 
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
            finally 
            { 
                if (fileStream != null) fileStream.Close(); 
                if (streamReader != null) streamReader.Close(); 
            }
        }
    }
}