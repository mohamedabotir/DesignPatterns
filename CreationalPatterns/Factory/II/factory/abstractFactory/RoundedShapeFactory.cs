using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.abstractFactory
{
    public class RoundedShapeFactory : ShapeFactory
    {
        public override IShape CreateShape(Shape shape) =>

           shape switch
           {
               Shape.Rectangle => new RoundedRectangle(),
               Shape.Square => new RoundedSquare(),
               _ => throw new IndexOutOfRangeException("Operations Didn't Support yet !")
           };



    }
}