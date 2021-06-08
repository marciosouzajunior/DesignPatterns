using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{

    /*
     * AbstractFactory
     * 
     * Declares an interface for operations that create abstract product objects.
     */
    interface IShapeFactory
    {
        IShape CreateRectangle();
        IShape CreateCircle();
    }
}
