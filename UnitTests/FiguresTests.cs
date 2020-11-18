using System;
using GeometryTools.Infrastructure.Figures;
using Xunit;

namespace UnitTests
{
    public class FiguresTests
    {
        [Fact]
        public void RightTriangleAreaCalculationCorrect()
        {
            var figure = new RightTriangle(3, 6);
            var result = figure.Area;
            Assert.Equal(9, result);
        }

        [Fact]
        public void SquareAreaCalculationCorrect()
        {
            var figure = new Square(5);
            var result = figure.Area;
            Assert.Equal(25, result);
        }
    }
}