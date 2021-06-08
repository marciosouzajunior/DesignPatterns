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
    class Circle2D : ICircle
    {
        public void Draw()
        {
            Console.WriteLine("Circle2D.Draw()");
        }
    }
}
