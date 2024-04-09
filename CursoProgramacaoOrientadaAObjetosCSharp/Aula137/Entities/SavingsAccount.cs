using Aula137.Entities;
using System.Runtime.InteropServices.Marshalling;

namespace Aula137.Entities
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

        public override void WithDraw(double amount) //override é usado para sobrescrever um metodo de uma superclass em uma subclass
        {
            Balance -= amount;
        }
    }
}
