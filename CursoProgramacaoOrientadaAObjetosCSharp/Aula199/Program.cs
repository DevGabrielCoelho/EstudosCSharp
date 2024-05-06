using System;

namespace Aula199
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Estudos\CursoProgramacaoOrientadaAObjetosCSharp\Aula199\MyFolder";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string folder in folders)
                {
                    string[] strings = folder.Split('\u005C');
                    Console.WriteLine(strings[strings.Length - 1]);
                }
                
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFiles:");
                foreach (string file in files)
                {
                    string[] strings = file.Split('\u005C');
                    if (strings[strings.Length - 2] == "MyFolder") Console.WriteLine(strings[strings.Length - 1]);
                    else Console.WriteLine($"{strings[strings.Length - 2]}\u005C{strings[strings.Length - 1]} abiaba");
                }

                Directory.CreateDirectory(path + @"\NewFolder");
                File.Create(path + @"\NewFolder\NewFolderTestText.txt");

                folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\n\nFolders:");
                foreach (string folder in folders)
                {
                    string[] strings = folder.Split('\u005C');
                    Console.WriteLine(strings[strings.Length - 1]);
                }

                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFiles:");
                foreach (string file in files)
                {
                    string[] strings = file.Split('\u005C');
                    if (strings[strings.Length - 2] == "MyFolder") Console.WriteLine(strings[strings.Length - 1]);
                    else Console.WriteLine($"{strings[strings.Length - 2]}\u005C{strings[strings.Length - 1]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }

        }
    }
}