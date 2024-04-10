using Aula143.Entities;
using System.Runtime.InteropServices.Marshalling;

namespace Aula143.Entities
{
    sealed class SavingsAccount : Account //sealed pode ser usado em uma class para que não aja criações de subclasses dela
    {
        public double InterestRate { get; private set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public sealed override void WithDraw(double amount) //sealed pode ser usado em um metodo sobrescrito para que não tenha outras
                                                            //sobrescrições em outras subclasses
        {
            Balance -= amount;
        }
    }
}
