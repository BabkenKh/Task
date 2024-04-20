using GeometricCalculator.Shapes;

namespace GeometricCalculator
{
    public class ShapeCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
