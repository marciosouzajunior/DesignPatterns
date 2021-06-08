using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class Factory2D : IFactory
    {
        public ICircle CreateCircle()
        {
            return new Circle2D();
        }

        public ISquare CreateSquare()
        {
            return new Square2D();
        }
    }
}
