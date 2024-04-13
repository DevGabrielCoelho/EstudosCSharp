using System.Globalization;
using ExercicioFixacao03.Entities.Exceptions;

namespace ExercicioFixacao03.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (holder == null || holder == "")
            {
                throw new AccountExceptions("Holder name was not entered");
            }

            int charnumbers = 0;
            foreach (char c in holder)
            {
                if (char.IsNumber(c))
                {
                    charnumbers++;
                }
            }
            if (holder.Length == charnumbers)
            {
                throw new AccountExceptions("A string contém apenas números.");
            }

            if (balance < 0 || balance == double.PositiveInfinity)
            {
                throw new AccountExceptions("Balance value not accepted");
            }
            if (withdrawLimit < 0 || withdrawLimit == double.PositiveInfinity)
            {
                throw new AccountExceptions("Withdraw limit value not accepted");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new AccountExceptions("Not enough balance");
            }
            if (WithdrawLimit < amount)
            {
                throw new AccountExceptions("The amount withdrawals exceeds the limit");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Number: {Number}\n" +
                   $"Holder: {Holder}\n" +
                   $"Balance: {Balance.ToString("f2", CultureInfo.InvariantCulture)}\n" +
                   $"Withdraw Limit: {WithdrawLimit.ToString("f2", CultureInfo.InvariantCulture)}";
        }
        
    }
}
