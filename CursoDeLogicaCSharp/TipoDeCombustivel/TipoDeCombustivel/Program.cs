using System;

namespace TipoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int gasolina = 0;
            int alcool = 0;
            int disel = 0;

            int numero = int.Parse(Console.ReadLine());

            while (numero != 4)
            {
                if (numero == 1) alcool += 1;
                else if (numero == 2) gasolina += 1;
                else if (numero == 3) disel += 1;
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + disel);

        }
    }
}