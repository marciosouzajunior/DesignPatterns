using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class Client
    {

        /*
         * Client
         * 
         * Uses only interfaces declared by AbstractFactory and AbstractProduct classes.
         */
        public void Run()
        {

            IShapeFactory shapeFactory;
            IShape shape;

            // Factory can be initialized with a simple assignment of a 
            // new factory instance at the beginning of the program:
            shapeFactory = new Shape2DFactory();
            shape = shapeFactory.CreateCircle();
            shape.Draw();

            shapeFactory = new Shape3DFactory();
            shape = shapeFactory.CreateCircle();
            shape.Draw();

        }

    }

}
