using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] par = new int[5];
            int[] impar = new int[5];
            int parCount = 0;
            int imparCount = 0;
            for (int i = 0; i < 15; i++) 
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    if (parCount == 5)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine($"par[{j}] = {par[j]}");
                        }
                        par = new int[5];
                        parCount = 0;
                    }
                    par[parCount] = input;
                    parCount++;
                }

                else
                {
                    if (imparCount == 5)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine($"impar[{j}] = {impar[j]}");
                        }
                        impar = new int[5];
                        imparCount = 0;
                    }
                    impar[imparCount] = input;
                    imparCount++;
                }
            }
            for (int i = 0;i < imparCount;i++)
            {
                Console.WriteLine($"impar[{i}] = {impar[i]}");
            }
            for (int i = 0;i < parCount;i++)
            {
                Console.WriteLine($"par[{i}] = {par[i]}");
            }
        }
    }
}