using System;
using System.Collections.Generic;
using Entities;

namespace Services
{

    class PaymentService
    {
        public ITaxService TaxService { get; private set; }

        public PaymentService(ITaxService taxService)
        {
            TaxService = taxService;
        }

        public void PaymentServices(Contract contract, int months)
        {
            double value = contract.TotalValue / months;
            for (int i = 0; i < months; i++)
            {
                DateTime date = contract.Date;
                date = date.AddMonths(i);

                double tax = TaxService.Interest(value, i + 1);
                tax = TaxService.PaymentTax(value);

                contract.AddInstallment(new Installment(date, tax));
            }
        }
    }
}
