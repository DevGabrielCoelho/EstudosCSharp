using System;
using System.Globalization;

namespace ExercicioClassObj1
{
    class Retangulo
    {
        public double Largura, 
                      Altura;
        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
        public override string ToString()
        {
            return $"AREA = {Area().ToString("f2", CultureInfo.InvariantCulture)}\n" +
                   $"PERÍMETRO = {Perimetro().ToString("f2", CultureInfo.InvariantCulture)}\n" +
                   $"DIAGONAL = {Diagonal().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
