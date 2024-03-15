using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace ExercicioVetor9
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            string[] mercadoria = new string[quantidade];
            double[] compra = new double[quantidade];
            double[] venda = new double[quantidade];
            double lucro = 0.0;
            int menosdezporcento = 0;
            int dezporcento = 0;
            int vinteporcento = 0;
            double lucrototal = 0.0;
            double vendatotal = 0.0;
            double compratotal = 0.0;

            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                mercadoria[i] = entrada[0];
                compra[i] = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < quantidade; i++)
            {   // 100*1/10
                lucro = (double)((double)((double)(venda[i] - compra[i])*100.0)/compra[i]);
                compratotal += compra[i];
                vendatotal += venda[i];
                if (lucro < 10) menosdezporcento++;
                else if (lucro >= 10 && lucro <= 20) dezporcento++;
                else if (lucro > 0.20) vinteporcento++;
            }

            lucrototal = (double)(vendatotal - compratotal);

            Console.WriteLine("Lucro abaixo de 10%: " + menosdezporcento);
            Console.WriteLine("Lucro entre 10% e 20%: " + dezporcento);
            Console.WriteLine("Lucro acima de 20%: " + vinteporcento);
            Console.WriteLine("Valor total de compra: " + compratotal.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + vendatotal.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucrototal.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}