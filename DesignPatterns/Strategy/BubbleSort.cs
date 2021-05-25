using System;

namespace DesignPatterns.Strategy
{

    /* 
     * ConcreteStrategy
     * 
     * Implements the algorithm using the Strategy interface.
     */
    public class BubbleSort : ISort
    {
        public void sort(int[] numbers)
        {
            Console.WriteLine("Bubble sort.");
        }
    }

}
