using System.Globalization;

namespace Entities
{
    class Product : IComparable
    {
        public string Name { get; private set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Error! Argument Exception");
            }
            Product other = obj as Product; 
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
