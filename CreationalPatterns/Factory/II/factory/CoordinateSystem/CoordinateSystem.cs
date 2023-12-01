
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
        //let's create another system using construcor or using mode using enum
        public CoordinateSystem(float r, float theta)
        {
            x = r * Math.Cos(theta);
            y = r * Math.Sin(theta);
        }
        public CoordinateSystem(double xValue, double yValue, Coordinate coordinate = Coordinate.Cartesian)
        {
            switch (coordinate)
            {
                case Coordinate.Cartesian:
                    x = xValue; y = yValue;
                    break;
                case Coordinate.Polar:
                    x = xValue * Math.Cos(yValue);
                    y = xValue * Math.Sin(yValue);
                    break;
                default:
                    throw new InvalidOperationException("UnBounded Operation !");
                    break;
            }


        }
        public override string ToString() => $"X:{x},Y:{y}";
    }
    public enum Coordinate
    {
        Cartesian,
        Polar
    }
}