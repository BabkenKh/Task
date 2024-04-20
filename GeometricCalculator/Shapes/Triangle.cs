
namespace GeometricCalculator.Shapes
{
    public class Triangle : IShape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if ((side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1))
            {
                throw new ArgumentException("The lengths of the given sides do not correspond to the property of a triangle.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double perimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
        }

        public bool IsRightTriangle()
        {
            return side1 * side1 + side2 * side2 == side3 * side3
                || side1 * side1 + side3 * side3 == side2 * side2
                || side2 * side2 + side3 * side3 == side1 * side1;
        }
    }
}
