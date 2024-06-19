/*
 Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada
Não há nenhuma entrada neste problema.

Saída
Imprima a sequencia conforme exemplo abaixo.

Exemplo de Saída
I=0 J=1
I=0 J=2
I=0 J=3
I=0.2 J=1.2
I=0.2 J=2.2
I=0.2 J=3.2
.....
I=2 J=?
I=2 J=?
I=2 J=?
 */
using System;
using System.Globalization;

namespace BeeCrownd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (double i = 0.0; i <= 2; i += 0.2)
            {
                for(double j = 1.0; j <= 3; j++)
                {
                    if (i.ToString("f1", CultureInfo.InvariantCulture).Split('.')[1] == "0") Console.WriteLine($"I={Math.Ceiling(i)} J={Math.Ceiling(j + i)}");
                    
                    else Console.WriteLine($"I={i.ToString("f1")} J={(j+i).ToString("f1")}");
                }
            }
        }
    }
}