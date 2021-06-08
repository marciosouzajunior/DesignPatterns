using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class Shape2DFactory : IShapeFactory
    {
        public IShape CreateCircle()
        {
            return new Circle2D();
        }

        public IShape CreateRectangle()
        {
            return new Rectangle2D();
        }
    }
}
