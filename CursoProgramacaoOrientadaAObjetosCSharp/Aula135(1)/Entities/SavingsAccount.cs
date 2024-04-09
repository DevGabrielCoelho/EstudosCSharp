using Aula135.Entities;

namespace Aula135_1_.Entities
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
