/*
 Na matemática, um número perfeito é um número inteiro para o qual a soma de todos os seus divisores positivos próprios 
(excluindo ele mesmo) é igual ao próprio número. Por exemplo o número 6 é perfeito, pois 1+2+3 é igual a 6. 
Sua tarefa é escrever um programa que imprima se um determinado número é perfeito ou não.

Entrada
A entrada contém vários casos de teste. A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 20), 
indicando o número de casos de teste da entrada. Cada uma das N linhas seguintes contém um valor inteiro X (1 ≤ X ≤ 108), 
que pode ser ou não, um número perfeito.

Saída
Para cada caso de teste de entrada, imprima a mensagem “X eh perfeito” ou “X nao eh perfeito”, 
de acordo com a especificação fornecida.

Exemplo de Entrada	
3
6
5
28

Exemplo de Saída
6 eh perfeito
5 nao eh perfeito
28 eh perfeito
 */

using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int j = 1; j < input; j++) 
                {
                    if (input % j == 0) sum += j;
                }
                if (sum == input) Console.WriteLine($"{input} eh perfeito");
                else Console.WriteLine($"{input} nao eh perfeito");
            }
        }
    }
}