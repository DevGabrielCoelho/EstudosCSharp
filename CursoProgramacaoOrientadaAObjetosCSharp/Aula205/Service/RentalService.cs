using Aula205.Entities;

namespace Aula205.Service
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double total;
            if (duration.TotalHours <= 12.0) 
            {
                double ceiling = Math.Ceiling(duration.TotalHours);
                total = PricePerHour * ceiling;
            }
            else 
            {
                double ceiling = Math.Ceiling(duration.TotalDays);
                total = PricePerDay * ceiling;
            }
            carRental.Invoice = new Invoice(total, _taxService.Tax(total));
        }
    }
}
