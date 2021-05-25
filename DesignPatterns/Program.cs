using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            * Strategy
            * 
            * Encapsulate algorithms and make them interchangable.
            * A code without strategies could look like this:              
            *                          
            string sortStrategy = "bubble";
            switch (sortStrategy)
            {
                case "bubble":
                    SortWithBubbleSort();
                    break;
                case "selection":
                    SortWithSelecionSort();
                    break;
            }
            */

            // Sample code
            int[] numbers = new int[] { 2, 1, 3 };

            // To instantiate Sorter (Context),
            // you pass it the ISort (Strategy) you want to use:
            Sorter bubble = new Sorter(new BubbleSort());
            bubble.sort(numbers);

            Sorter selection = new Sorter(new SelectionSort());
            selection.sort(numbers);

        }

    }

}
