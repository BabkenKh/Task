using GeometricCalculator.Shapes;

namespace GeometricCalculator.Tests
{
    public class ShapeTests
    {
        private const double Radius1 = 2;
        private const double CircleExpectedArea1 = 12.56637;

        private const double Radius2 = 10;
        private const double CircleExpectedArea2 = 314.15927;

        private const double Radius3 = 14.21;
        private const double CircleExpectedArea3 = 634.36327;

        private const double IncorrectRadius = 0;
        private const double CircleIncorrectExpectedArea = 0;
        private const string CircleExceptionReasonMessage = "Radius must be positive.";

        private const double FirstSide1 = 3;
        private const double SecodSide1 = 4;
        private const double ThirdSide1 = 5;
        private const bool IsRightTriangle1 = true;
        private const double TrinagleExpectedArea1 = 6;

        private const double FirstSide2 = 20;
        private const double SecodSide2 = 25;
        private const double ThirdSide2 = 18;
        private const bool IsRightTriangle2 = false;
        private const double TrinagleExpectedArea2 = 178.2903;

        private const double IncorrectFirstSide = 3;
        private const double IncorrectSecodSide = 6;
        private const double IncorrectThirdSide = 10;
        private const string TriangleExceptionReasonMessage = "The lengths of the given sides do not correspond to the property of a triangle.";

        [Theory]
        [InlineData(Radius1, CircleExpectedArea1)]
        [InlineData(Radius2, CircleExpectedArea2)]
        [InlineData(Radius3, CircleExpectedArea3)]
        [InlineData(IncorrectRadius, CircleIncorrectExpectedArea)]
        public void CalculateCircleArea(double radius, double expectedArea)
        {
            try
            {
                Circle circle = new Circle(radius);

                ShapeCalculator shapeCalculator = new ShapeCalculator();
                double actualArea = shapeCalculator.CalculateArea(circle);

                Assert.Equal(expectedArea, actualArea, 5);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal(CircleExceptionReasonMessage, ex.Message);
            }
        }

        [Theory]
        [InlineData(FirstSide1, SecodSide1, ThirdSide1, IsRightTriangle1, TrinagleExpectedArea1)]
        [InlineData(FirstSide2, SecodSide2, ThirdSide2, IsRightTriangle2, TrinagleExpectedArea2)]
        [InlineData(IncorrectFirstSide, IncorrectSecodSide, IncorrectThirdSide, false, 0)]
        public void CalculateTriangleAreaAndCheckForSquareness(double side1, double side2, double side3, bool isRightTriangle, double expectedArea)
        {
            try
            {
                Triangle triangle = new Triangle(side1, side2, side3);

                ShapeCalculator shapeCalculator = new ShapeCalculator();
                double actualArea = shapeCalculator.CalculateArea(triangle);

                Assert.Equal(isRightTriangle, triangle.IsRightTriangle());
                Assert.Equal(expectedArea, actualArea, 4);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal(TriangleExceptionReasonMessage, ex.Message);
            }
        }
    }
}