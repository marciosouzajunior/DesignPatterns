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

            IPerson family1 = new Family();
            IPerson elizabeth = new Person("Elizabeth");
            IPerson philip = new Person("Philip");
            family1.add(elizabeth);
            family1.add(philip);

            IPerson family2 = new Family();
            IPerson charles = new Person("Charles");
            IPerson diana = new Person("Diana");
            family2.add(charles);
            family2.add(diana);

            family1.add(family2);
            family1.print();

        }

    }
}
