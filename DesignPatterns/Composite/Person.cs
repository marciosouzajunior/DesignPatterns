﻿using System;
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

    public class Person : IPerson
    {

        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void add(IPerson p)
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            Console.Write(name + "-");
        }
    }
}
