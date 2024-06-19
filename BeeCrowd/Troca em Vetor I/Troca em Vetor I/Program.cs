/*
 Faça um programa que leia um vetor N[20]. Troque a seguir, o primeiro elemento com o último, 
o segundo elemento com o penúltimo, etc., até trocar o 10º com o 11º. Mostre o vetor modificado.

Entrada
A entrada contém 20 valores inteiros, positivos ou negativos.

Saída
Para cada posição do vetor N, escreva "N[i] = Y", onde i é a posição do vetor e Y é o valor armazenado naquela posição.

Exemplo de Entrada	
0
-5
...
63
230

Exemplo de Saída
N[0] = 230
N[1] = 63
...
N[18] = -5
N[19] = 0
 */

using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[20];
            for (int i = 0; i < vetor.Length; i++) 
            {
                vetor[vetor.Length-1-i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < vetor.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {vetor[i]}");
            }
        }
    }
}