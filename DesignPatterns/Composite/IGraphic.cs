using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{

    /*
     * Component
     * 
     * - declares th e interface for objects in the composition.
     * - implements default behavior for the interface common to all classes,
     * as appropriate.
     * - declares an interface for accessing and managing its child components.
     * - (optional) defines an interface for accessing a component's parent in the 
     * recursive structure, and implements it if that's appropriate.
     */

    public interface IGraphic
    {
        void Add(IGraphic graphic);
        void Draw();
        void SetColor(ConsoleColor color);
    }

}
