using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.abstractFactory
{
    public class BasicShapeFactory : ShapeFactory
    {
        public override IShape CreateShape(Shape shape) =>

          shape switch
          {
              Shape.Rectangle => new Rectangle(),
              Shape.Square => new Square(),
              _ => throw new IndexOutOfRangeException("Operations Didn't Support yet !")
          };

    }
}