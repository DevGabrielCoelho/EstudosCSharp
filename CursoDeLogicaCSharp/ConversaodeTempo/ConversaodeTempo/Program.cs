using System;

namespace conv
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = int.Parse(Console.ReadLine());
            double segundos = sec % 60;
            double minutos = (sec / 60) % 60;
            double horas = (sec / 60) / 60;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}