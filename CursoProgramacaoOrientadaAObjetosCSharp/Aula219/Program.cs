using System;
using System.Collections.Generic;
using Aula219.Entities;

namespace Aula219
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Test1> test1s = new HashSet<Test1>();
            test1s.Add(new(1,"a"));
            test1s.Add(new(2,"b"));
            test1s.Add(new(3,"c"));
            
            HashSet<Test2> test2s = new HashSet<Test2>();
            test2s.Add(new(1,"a"));
            test2s.Add(new(2,"b"));
            test2s.Add(new(3,"c"));

            Test1 test1Confirm = new(1, "a");
            Test2 test2Confirm = new(1, "a");

            Console.WriteLine(test1s.Contains(test1Confirm));
            Console.WriteLine(test2s.Contains(test2Confirm));

        }
    }
}