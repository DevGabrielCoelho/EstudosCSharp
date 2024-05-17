using System;
using System.Collections.Generic;

namespace Aula217 
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add ("a");
            set.Add ("b");
            set.Add ("c");
            set.Add ("c");

            foreach (string s in set)
            {
                Console.Write (s + " ");
            }
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            SortedSet<int> ints = new SortedSet<int>();
            ints.Add (1);
            ints.Add (3);
            ints.Add (5);
            SortedSet<int> ints2 = new SortedSet<int>();
            ints2.Add (2);
            ints2.Add (4);
            ints2.Add (5);
            ints2.Add (6);
            foreach (int s in ints)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach (int s in ints2)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            SortedSet<int> ints3 = new SortedSet<int>(ints);
            ints3.UnionWith (ints2);
            foreach (int s in ints3)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            ints3 = new SortedSet<int>(ints);
            ints3.IntersectWith(ints2);
            foreach (int s in ints3)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            ints3 = new SortedSet<int>(ints);
            ints3.ExceptWith(ints2);
            foreach (int s in ints3)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-\n");

        }
    }   
}