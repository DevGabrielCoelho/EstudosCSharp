using System.Collections.Generic;

namespace Services
{
    internal interface ITaxService
    {
        public double PaymentTax(double amount);
        public double Interest(double amount, int months);

    }
}
