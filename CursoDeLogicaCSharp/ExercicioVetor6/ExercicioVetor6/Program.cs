using System;

namespace ExercicioVetor6
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] nomes = new string[quantidade];
            int[] idades = new int[quantidade];
            int maisvelho = 0;
            int posicao = 0;
            
            for(int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                nomes[i] = entrada[0];
                idades[i] = int.Parse(entrada[1]);
            }

            for (int i = 0; i < quantidade; i++)
            {
                if (i == 0)
                {
                    maisvelho = idades[i];
                    posicao = i;
                }
                else
                {
                    if (idades[i] > maisvelho)
                    {
                        maisvelho = idades[i];
                        posicao = i;
                    }
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nomes[posicao]);

        }
    }
}