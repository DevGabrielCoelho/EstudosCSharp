using System;
using System.Globalization;

namespace ExercicioClassObj3
{
    class Aluno
    {
        public string Nome;
        public double PrimeiraNota, SegundaNota, TerceiraNota;

        public double NotaFinal()
        {
            return PrimeiraNota + SegundaNota + TerceiraNota;
        }

        public override string ToString()
        {
            if (NotaFinal() >= 60.00)
            {
                return $"{NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}\n" +
                       $"APROVADO";
            }
            else
            {
                return $"{NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}\n" +
                       $"REPROVADO\n" +
                       $"FALTARAM {(60.00 - NotaFinal()).ToString("f2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
