using System;

namespace Aula200
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula200\MyFolder\TestText01.txt";
            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}\n" +
                              $"PathSeparator: {Path.PathSeparator}\n" +
                              $"GetDirectoryName: {Path.GetDirectoryName(path)}\n" +
                              $"GetFileName: {Path.GetFileName(path)}\n" +
                              $"GetExtension: {Path.GetExtension(path)}\n" +
                              $"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}\n" +
                              $"GetFullPath: {Path.GetFullPath(path)}\n" +
                              $"GetTempPath: {Path.GetTempPath()}");
        }
    }
}