using System;
using System.Linq;

namespace Aula235
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, };

            IEnumerable<int> Even = ints.Where(x => x % 2 == 0);
            IEnumerable<int> Odd = ints.Where(x => x % 2 != 0);

            foreach (int x in Even)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (int x in Odd)
            {
                Console.WriteLine(x);
            }
        }
    }
}