using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class Factory3D : IFactory
    {
        public ICircle CreateCircle()
        {
            return new Circle3D();
        }

        public ISquare CreateSquare()
        {
            return new Square3D();
        }
    }
}
