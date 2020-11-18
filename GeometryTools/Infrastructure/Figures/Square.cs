using System;

namespace GeometryTools.Infrastructure.Figures
{
    public class Square : Figure
    {
        public double SideLength { get; private set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Area => Math.Pow(SideLength, 2);
    }
}