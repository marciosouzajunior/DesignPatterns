
namespace DesignPatterns.Strategy
{

    /*
     * Context
     * 
     * - is configured with a ConcreteStrategy object.
     * - maintains a reference to a Strategy object.
     * - may define an interface that lets Strategy access its data.
     */
    public class Sorter
    {
        private ISort sortStrategy;

        public Sorter(ISort sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void sort(int[] numbers)
        {
            sortStrategy.sort(numbers);
        }

    }

}
