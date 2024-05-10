using Aula205.Entities;
using Aula205.Service;
using System;
using System.Globalization;

namespace Aula205
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter rental data\r\n" +
                              "Car model: ");
                    Vehicle carModel = new(Console.ReadLine());

                    Console.Write("\nPickup (dd/MM/yyyy hh:mm): ");
                    DateTime pickupCar = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                    Console.Write("Return (dd/MM/yyyy hh:mm): ");
                    DateTime returnCar = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                    CarRental carRental = new(pickupCar, returnCar, carModel);

                    Console.Write("\nEnter price per hour: ");
                    double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Enter price per day: ");
                    double priceperDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    RentalService rentalService = new(pricePerHour, priceperDay, new BrazilTaxService());
                    rentalService.ProcessInvoice(carRental);

                    Console.WriteLine($"\n{carRental.Invoice}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error! {ex.Message}");
                }
                Console.WriteLine("enter!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}