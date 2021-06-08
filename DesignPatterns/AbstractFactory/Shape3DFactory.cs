using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class Shape3DFactory : IShapeFactory
    {
        public IShape CreateCircle()
        {
            return new Circle3D();
        }

        public IShape CreateRectangle()
        {
            return new Rectangle3D();
        }
    }
}
