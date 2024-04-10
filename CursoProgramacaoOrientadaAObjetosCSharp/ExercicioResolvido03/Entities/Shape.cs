using ExercicioResolvido03.Entities.Enums;

namespace ExercicioResolvido03.Entities
{
    abstract class Shape
    {
        Color Color { get; set; }

        protected Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        abstract public double Area();
    }
}
