using System;
using System.Linq;
using GeometryTools.Infrastructure;

namespace GeometryTools
{
    public static class Geometry
    {
        public static double CalculateArea(params IGeometricObject[] objects) => objects.Sum(o => o.Area);
    }
}