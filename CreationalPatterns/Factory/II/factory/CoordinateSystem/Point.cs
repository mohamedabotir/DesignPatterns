
namespace factory.Point;

public partial class Point
{



    public static class CoordinateFactory
    {
        public static Point CreateCartesianSystem(double point1, double point2)
        {

            return new Point(point1, point2);
        }
        public static Point CreatePolarSystem(double r, double theta)
        {

            return new Point(r * Math.Cos(theta), r * Math.Sin(theta));
        }
    }

}
public enum Coordinate
{
    Cartesian,
    Polar
}
