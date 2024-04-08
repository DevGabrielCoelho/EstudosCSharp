using ExercicioProposto01.Entities;
using ExercicioProposto01.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioProposto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cliente data:\n" +
                          "Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Client client = new Client
                (
                    clientName,
                    clientEmail,
                    clientBirthDate
                );

            Console.Write("\nEnter order data:\n" +
                          "Status: ");
            OrderStatus orderStatus = OrderStatus.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int orderQuantity = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now.ToUniversalTime(), orderStatus, client);
            for (int i = 0; i < orderQuantity; i++)
            {
                Console.Write($"Enter #{i + 1} item data:\n" +
                               "Product name: ");
                string orderProductName = Console.ReadLine();
                Console.Write("Product price: ");
                double orderProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int orderProductQuantity = int.Parse(Console.ReadLine());
                Product product = new(orderProductName, orderProductPrice);
                OrderItem orderItem = new(orderProductQuantity, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine(order);


        }
    }
}