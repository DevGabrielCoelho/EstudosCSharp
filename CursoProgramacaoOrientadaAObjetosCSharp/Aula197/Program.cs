using System;

namespace Aula197
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream fileStream = new(@"C:\Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula197\TextTest01.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new(fileStream))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            Console.WriteLine(streamReader.ReadLine());
                        }
                    }
                    Console.WriteLine();
                    using (StreamReader streamReader = File.OpenText(@"C:\Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula197\TextTest01.txt"))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            Console.WriteLine(streamReader.ReadLine());
                        }
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