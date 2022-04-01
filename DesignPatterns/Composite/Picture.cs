using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    /*
     * Composite
     * 
     * - defines behavior for components having children.
     * - stores child components.
     * - implements child-related operations in the component interface.
     */

    class Picture : IGraphic
    {
        List<IGraphic> graphicList = new List<IGraphic>();
        ConsoleColor? color;

        public void Add(IGraphic graphic)
        {
            graphicList.Add(graphic);
        }

        public void Draw()
        {
            if (color != null)
            {
                Console.ForegroundColor = color.Value;
            }

            foreach (var graphic in graphicList)
            {
                graphic.Draw();
            }
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }
    }
}
