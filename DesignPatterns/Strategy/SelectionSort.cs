using System;

namespace DesignPatterns.Strategy
{

    /* 
     * ConcreteStrategy
     * 
     * Implements the algorithm using the Strategy interface.
     */
    public class SelectionSort : ISort
    {
        public void sort(int[] numbers)
        {
            Console.WriteLine("Selection sort.");
        }
    }

}
