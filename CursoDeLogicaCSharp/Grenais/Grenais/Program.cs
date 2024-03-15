using System;

namespace Grenais
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetir = 1;
            int inter = 0;
            int gremio = 0;
            int empate = 0;
            int numerorepeticao = 0;
            while (repetir == 1)
            {
                numerorepeticao += 1;
                string[] placar = Console.ReadLine().Split(' ');
                if (int.Parse(placar[0]) == int.Parse(placar[1])) empate += 1;
                else
                {
                    if (int.Parse(placar[0]) > int.Parse(placar[1])) inter += 1;
                    else gremio += 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                repetir = int.Parse(Console.ReadLine());
                while (repetir < 1 || repetir > 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    repetir = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(numerorepeticao + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empate);
            if (inter > gremio) Console.WriteLine("Inter venceu mais");
            else Console.WriteLine("Gremio venceu mais");

        }
    }
}