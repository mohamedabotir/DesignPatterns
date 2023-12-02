
namespace factory.Point;

public partial class Point
{
    private double x, y;
    private Point(double xValue, double yValue)
    {
        x = xValue;
        y = yValue;
    }


    //let's create another system using construcor or using mode using enum
    private Point(float r, float theta)
    {

        x = r * Math.Cos(theta);
        y = r * Math.Sin(theta);
    }
    #region   another method to support both system using enum mode
    private Point(double xValue, double yValue, Coordinate coordinate = Coordinate.Cartesian)
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
    #endregion

    #region  add both system but using factory Method
    public static Point CreateCartesian(double xValue, double yValue) => new Point(xValue, yValue);
    public static Point CreatePolar(double xValue, double yValue) => new Point(xValue * Math.Cos(yValue), xValue * Math.Sin(yValue));

    #endregion
    public override string ToString() => $"X:{x},Y:{y}";
}
