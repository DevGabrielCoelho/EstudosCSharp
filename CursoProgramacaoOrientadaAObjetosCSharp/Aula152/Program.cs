using Aula152.Entities;
using Aula152.Entities.Exceptions;
using System;
using System.Globalization;

namespace Aula152
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter reservation data:\n" +
                          "Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (DD/MM/YYYY): ");
                DateTime dateCheckIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Check-out date (DD/MM/YYYY): ");
                DateTime dateCheckOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Reservation reservation = new(roomNumber, dateCheckIn, dateCheckOut);

                Console.WriteLine("\nReservation Data:");
                Console.WriteLine(reservation);

                Console.Write("\nEnter new checkin date: ");
                dateCheckIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Enter new checkout date: ");
                dateCheckOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                reservation.UpdateDates(dateCheckIn, dateCheckOut);

                Console.WriteLine("Updated reservation data:");
                Console.WriteLine(reservation);
            }
            catch (DomainException exception)
            {
                Console.WriteLine($"Error! {exception.Message}");
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Error! {exception.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error! {exception.Message}");
            }
        }
    }
}