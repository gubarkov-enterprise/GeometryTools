namespace GeometryTools.Infrastructure.Figures
{
    public class RightTriangle : Figure
    {
        public double LegA { get; private set; }

        public double LegB { get; private set; }


        public RightTriangle(double legA, double legB)
        {
            LegA = legA;
            LegB = legB;
        }


        public override double Area => (LegA * LegB) / 2d;
    }
}