using ExercicioResolvido03.Entities.Enums;

namespace ExercicioResolvido03.Entities
{
    sealed class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        sealed public override double Area()
        {
            return Width*Height;
        }
    }
}
