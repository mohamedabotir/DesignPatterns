
namespace factory.CoordinateSystem
{
    public class CoordinateSystem
    {
        private double x, y;
        public CoordinateSystem(double xValue, double yValue)
        {
            x = xValue;
            y = yValue;
        }
        public override string ToString() => $"X:{x},Y:{y}";
    }
    enum Coordinate
    {
        Cartesian,
        Polar
    }
}