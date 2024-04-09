using System.Text;
using System.Globalization;

namespace Aula135.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; private set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
                LoanLimit -= amount;
            }
            else Console.WriteLine("Valor negado");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Number: {Number}\n" +
                          $"Holder: {Holder}\n" +
                          $"Balance: {Balance.ToString("f2", CultureInfo.InvariantCulture)}\n" +
                          $"LoanLimit: {LoanLimit.ToString("f2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
