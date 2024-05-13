using System.Collections.Generic;

namespace Services
{
    class IPaypalTax : ITaxService
    {
        private double _paymentTaxAmount = 0.02;
        private double _interestAmount = 0.01;
        public double PaymentTax(double amount)
        {
            return amount * _paymentTaxAmount;
        }

        public double Interest(double amount, int months)
        {
            return amount * (_interestAmount * months);
        }
    }
}
