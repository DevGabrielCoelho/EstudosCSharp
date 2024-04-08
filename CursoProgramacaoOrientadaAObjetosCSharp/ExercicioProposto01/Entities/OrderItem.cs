namespace ExercicioProposto01.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product)
        {
            Product = product;
            Price = Product.Price;
            Quantity = quantity;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
