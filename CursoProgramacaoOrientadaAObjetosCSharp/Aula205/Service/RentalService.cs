using Aula205.Entities;

namespace Aula205.Service
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private BrazilTaxService _BrazilTaxService = new();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            if (duration.TotalHours <= 12.0) 
            {
                double ceiling = Math.Ceiling(duration.TotalHours);
                double total = PricePerHour * ceiling;
                carRental.Invoice = new Invoice(total, _BrazilTaxService.Tax(total));
            }
            else 
            {
                double ceiling = Math.Ceiling(duration.TotalDays);
                double total = PricePerDay * ceiling;
                carRental.Invoice = new Invoice(total, _BrazilTaxService.Tax(total));
            }
        }
    }
}
