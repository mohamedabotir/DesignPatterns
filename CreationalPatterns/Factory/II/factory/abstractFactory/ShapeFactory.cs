using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.abstractFactory
{
    public abstract class ShapeFactory
    {
        public abstract IShape CreateShape(Shape shape);

        public static ShapeFactory GetShapeType(bool isRounded) =>
              isRounded ? new RoundedShapeFactory() : new BasicShapeFactory();

    }
}