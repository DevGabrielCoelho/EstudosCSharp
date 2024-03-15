using System;
using System.Runtime.InteropServices;

namespace omaior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int x = int.Parse(a[0]);
            int y = int.Parse(a[1]);
            int z = int.Parse(a[2]);
            int calc = (x + y + Math.Abs(x - y)) / 2;
            int calc2 = (calc + z + Math.Abs(calc - z)) / 2;
            Console.WriteLine(calc2 + " eh o maior");
        }
    }
}