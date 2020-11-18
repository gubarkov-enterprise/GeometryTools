using GeometryTools;
using GeometryTools.Infrastructure.Figures;
using Xunit;

namespace UnitTests
{
    public class GeometryTests
    {
        [Fact]
        public void CalculatorSumsCorrectly()
        {
            var triangle = new RightTriangle(8, 6);
            var square = new Square(8);

            var result = Geometry.CalculateArea(square, triangle);
            Assert.Equal(88, result);
        }
    }
}