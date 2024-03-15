using System;

namespace TempoDeJogoComMinutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int INICIO, FIM, DURACAO, HORAS, MINUTOS;
            string[] X = Console.ReadLine().Split(' ');
            
            INICIO = ((int.Parse(X[0])) * 60) + int.Parse(X[1]);

            FIM = ((int.Parse(X[2])) * 60) + int.Parse(X[3]);

            if (INICIO < FIM)
            {
                DURACAO = FIM - INICIO;
            }
            else
            {
                DURACAO = FIM + ((24 * 60) - INICIO);
            }

            HORAS = DURACAO / 60;
            MINUTOS = DURACAO - (HORAS * 60);
            
            Console.WriteLine("O JOGO DUROU " + HORAS + " HORA(S) E " + MINUTOS + " MINUTO(S)");
        }
    }
}