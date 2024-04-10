using ExercicioResolvido03.Entities.Enums;

namespace ExercicioResolvido03.Entities
{
    sealed class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        sealed public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
