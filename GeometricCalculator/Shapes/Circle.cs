
namespace GeometricCalculator.Shapes
{
    public class Circle : IShape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive.");
            }

            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
