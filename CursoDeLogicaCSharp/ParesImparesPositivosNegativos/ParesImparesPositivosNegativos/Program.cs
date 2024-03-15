using System;

namespace ParesImparesPositivosNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, valor5, totalpar, totalimpar, totalpositivo, totalnegativo;

            totalpar = 0;
            totalimpar = 0;
            totalpositivo = 0;
            totalnegativo = 0;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            valor3 = int.Parse(Console.ReadLine());
            valor4 = int.Parse(Console.ReadLine());
            valor5 = int.Parse(Console.ReadLine());

            if (valor1 > 0)
            {
                totalpositivo += 1;
            }
            if (valor2 > 0)
            {
                totalpositivo += 1;
            }
            if (valor3 > 0)
            {
                totalpositivo += 1;
            }
            if (valor4 > 0)
            {
                totalpositivo += 1;
            }
            if (valor5 > 0)
            {
                totalpositivo += 1;
            }

            if (valor1 < 0)
            {
                totalnegativo += 1;
            }
            if (valor2 < 0)
            {
                totalnegativo += 1;
            }
            if (valor3 < 0)
            {
                totalnegativo += 1;
            }
            if (valor4 < 0)
            {
                totalnegativo += 1;
            }
            if (valor5 < 0)
            {
                totalnegativo += 1;
            }


            if ((valor1%2) == 0)
            {
                totalpar += 1;
            }
            if ((valor2%2) == 0)
            {
                totalpar += 1;
            }
            if ((valor3%2) == 0)
            {
                totalpar += 1;
            }
            if ((valor4%2) == 0)
            {
                totalpar += 1;
            }
            if ((valor5%2) == 0)
            {
                totalpar += 1;
            }

            totalimpar = 5 - totalpar;

            Console.WriteLine(totalpar + " valor(es) par(es)");
            Console.WriteLine(totalimpar + " valor(es) impar(es)");
            Console.WriteLine(totalpositivo + " valor(es) positivo(s)");
            Console.WriteLine(totalnegativo + " valor(es) negativo(s)");
        }
    }
}