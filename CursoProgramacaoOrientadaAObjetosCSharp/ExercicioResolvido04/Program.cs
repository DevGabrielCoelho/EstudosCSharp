using Entities;
using System;
using System.Formats.Asn1;

namespace ExercicioResolvido04
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
                HashSet<Log> logs = new HashSet<Log>();
                streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream)
                {
                    string[] lines = streamReader.ReadLine().Split(' ');
                    DateTime dateTime = DateTime.Parse(lines[1]);
                    if (logs.Contains(new Log(lines[0])))
                    {
                        Log[] logs1 = logs.ToArray();
                        for (int i = 0; i < logs.Count; i++)
                        {
                            if (logs1[i].Name == lines[0])
                            {
                                logs1[i].AddLog(DateTime.Parse(lines[1]));
                                break;
                            }
                        }
                        logs = logs1.ToHashSet();
                    }
                    else logs.Add(new Log(lines[0], dateTime));
                }
                Console.WriteLine("Total users: " + logs.Count);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error! " + ex.Message + "!");
            }
            finally
            {
                fileStream.Close();
                streamReader.Close();
            }
        }
    }
}