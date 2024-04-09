using Aula136.Entities;

namespace Aula136.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }
    }
}
