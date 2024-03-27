using System.Globalization;

namespace ExercicioConstrutoresEncapsulamentos
{
    class Conta
    {
        private string _nome;

        public int NumeroDaConta { get; }
        public double Saldo { get; private set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public Conta(int numeroDaConta, string nome, double depositarInicial)
        {
            _nome = nome;
            Saldo = depositarInicial;
            NumeroDaConta = numeroDaConta;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return $"Conta {NumeroDaConta}, Titular: {Nome}, Saldo: ${Saldo.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
