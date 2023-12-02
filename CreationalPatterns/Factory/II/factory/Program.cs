using static factory.Point.Point;
var cartesian = CoordinateFactory.CreateCartesianSystem(5, 2);
var polar = CoordinateFactory.CreatePolarSystem(5, 2);
Console.WriteLine(cartesian);
Console.WriteLine(polar);