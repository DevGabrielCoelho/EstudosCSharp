using System.Globalization;

namespace ExercicioFixacao01.Entities
{
    sealed class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufatureDate) : base(name, price)
        {
            ManufatureDate = manufatureDate;
        }
        public sealed override string PriceTag()
        {
            return $"{Name} (used) ${Price.ToString("f2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufatureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
