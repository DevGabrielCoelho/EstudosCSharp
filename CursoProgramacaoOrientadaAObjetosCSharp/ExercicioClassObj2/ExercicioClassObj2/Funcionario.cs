using System.Globalization;

namespace ExercicioClassObj2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto;
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto / 100.00 * porcentagem; 
        }
        public override string ToString()
        {
            return $"{Nome}, ${SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
