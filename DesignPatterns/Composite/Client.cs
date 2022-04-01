using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{

    /*
     * Client
     * 
     * - manipulates objects in the composition through the Component interface.
     */

    class Client
    {
        public void Run()
        {            
            IGraphic picture1 = new Picture();
            picture1.Add(new Line(30));
            picture1.Add(new Text("Composite Design Pattern"));
            picture1.Add(new Line(30));

            IGraphic picture2 = new Picture();
            picture2.Add(new Text("Drawing a rectangle:"));
            picture2.Add(new Rectangle());
            picture2.SetColor(ConsoleColor.DarkGreen);
            picture1.Add(picture2);

            picture1.Draw();
        }
    }
}
