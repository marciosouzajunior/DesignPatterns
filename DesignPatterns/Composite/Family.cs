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

    class Family : IPerson
    {

        List<IPerson> personList = new List<IPerson>();

        public void add(IPerson p)
        {
            personList.Add(p);
        }

        public void print()
        {            
            foreach (var p in personList)
            {

                // Line break when is family
                if (p is Family)
                    Console.WriteLine("");
               
                p.print();

            }
                
        }
    }
}
