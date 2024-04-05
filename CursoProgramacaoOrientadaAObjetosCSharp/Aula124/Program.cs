using Aula124.Entities;
using Aula124.Entities.Enums;
using System;

namespace Aula124
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1231;
            DateTime moment = DateTime.Now;
            OrderStatus status = OrderStatus.Processing;


            Order order = new Order()
            {
                Id = id,
                Moment = moment,
                Status = status
            };

            string txt = OrderStatus.Delivered.ToString();

            OrderStatus test = OrderStatus.Parse<OrderStatus>("PedingPayment");

            Console.WriteLine($"{txt}\n{test}");

            Console.WriteLine(order);
        }
    }
}