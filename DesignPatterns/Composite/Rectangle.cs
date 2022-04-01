using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{

    /*
     * Leaf
     * 
     * - represents leaf objects in the composition. A leaf has no children.
     * - defines behavior for primitive objects in the composition.
     */

    public class Rectangle : IGraphic
    {
        ConsoleColor? color;

        public void Add(IGraphic graphic)
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            if (color != null)
            {
                Console.ForegroundColor = color.Value;
            }

            Console.WriteLine("|--------|");
            Console.WriteLine("|        |");
            Console.WriteLine("|--------|");
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }
    }
}
