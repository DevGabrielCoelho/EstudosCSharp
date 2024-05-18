using System;

namespace ExercicioProposto03
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                Console.Write("Enter file full path: ");
                fileStream = new FileInfo(Console.ReadLine()).OpenRead();
                streamReader = new StreamReader(fileStream);
                Dictionary<string, int> candidates = new Dictionary<string, int>();
                while (!streamReader.EndOfStream)
                {
                    string[] line = streamReader.ReadLine().Split(',');
                    if (candidates.ContainsKey(line[0])) candidates[line[0]] += int.Parse(line[1]);
                    else candidates.Add(line[0], int.Parse(line[1]));
                }
                foreach (KeyValuePair<string, int> c in candidates)
                {
                    Console.WriteLine($"{c.Key}: {c.Value} votes!");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error! {ex.Message}!");
            }
            finally
            {
                if (fileStream != null) fileStream.Close();
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}