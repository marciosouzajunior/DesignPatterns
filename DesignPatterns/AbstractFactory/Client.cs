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

            IFactory factory;
            ISquare square;

            // Factory can be initialized with a simple assignment of a 
            // new factory instance at the beginning of the program:
            factory = new Factory2D();
            square = factory.CreateSquare();
            square.Draw();

            factory = new SquareFactory();
            square = factory.CreateSquare();
            square.Draw();

        }

    }

}
