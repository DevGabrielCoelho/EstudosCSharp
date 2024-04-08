using ExercicioProposto01.Entities.Enums;
using System.Globalization;
using System.Text;

namespace ExercicioProposto01.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = [];
        public Client Client { get; set; }


        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem items in Items)
            {
                total += items.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nORDER SUMMARY:\n" +
                          $"Order moment: {Moment.ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                          $"Order status: {Status}\n" +
                          $"Client: {Client.Name} {Client.BirthDate.ToString("(dd/MM/yyyy)")} - {Client.Email}\n\n" +

                          $"Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Product.Price.ToString("f2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, " +
                              $"Subtotal: ${item.SubTotal().ToString("f2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("f2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }

    }
}
