using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    /*
     * ConcreteProduct
     * 
     * - defines a product object to be created by the corresponding concrete factory.
     * - implements the AbstractProduct interface.
     */
    class Rectangle2D : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle2D.Draw()");
        }
    }
}
