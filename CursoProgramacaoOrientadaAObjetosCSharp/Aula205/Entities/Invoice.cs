using System.Globalization;

namespace Aula205.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment { 
            get 
            {
                return BasicPayment + Tax;
            } 
        }

        public override string ToString()
        {
            return $"INVOICE:\n" +
                   $"Basic payment: {BasicPayment.ToString("f2", CultureInfo.InvariantCulture)}\n" +
                   $"Tax: {Tax.ToString("f2", CultureInfo.InvariantCulture)}\n" +
                   $"Total payment: {TotalPayment.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
