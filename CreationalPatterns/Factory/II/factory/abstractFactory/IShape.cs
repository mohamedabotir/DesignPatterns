using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.abstractFactory
{
    public interface IShape
    {
        public void Draw();
    }
    public enum Shape
    {
        Rectangle, Square
    }
}